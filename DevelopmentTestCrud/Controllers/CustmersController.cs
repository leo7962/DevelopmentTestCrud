using AutoMapper;
using DevelopmentTestCrud.Contexts;
using DevelopmentTestCrud.Dtos;
using DevelopmentTestCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevelopmentTestCrud.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class CustmersController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public CustmersController(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet(Name = "Lista")]
        public async Task<ActionResult<List<CustomerDto>>> Get()
        {
            var entity = await dbContext.Customers.ToListAsync();
            var dtos = mapper.Map<List<CustomerDto>>(entity);
            return dtos;
        }

        [HttpGet("{id:int}", Name = "usuario")]
        public async Task<ActionResult<CustomerDto>> Get(int id)
        {
            var entity = await dbContext.Customers.FirstOrDefaultAsync(x => x.Id == id);
            if (entity == null)
            {
                return NotFound();
            }

            var dto = mapper.Map<CustomerDto>(entity);

            return dto;
        }

        [HttpPost(Name = "crear")]
        public async Task<ActionResult> Post([FromBody] CreateCustomerDto createCustomerDto)
        {
            var entity = mapper.Map<Customer>(createCustomerDto);
            dbContext.Add(entity);
            await dbContext.SaveChangesAsync();
            var customerDto = mapper.Map<CustomerDto>(entity);

            return new CreatedAtRouteResult("usuario", new { id = customerDto.Id }, customerDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] CreateCustomerDto createCustomerDto)
        {
            var entity = mapper.Map<Customer>(createCustomerDto);
            entity.Id = id;
            dbContext.Entry(entity).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}", Name = "eliminar")]
        public async Task<ActionResult> Delete (int id)
        {
            var exist = await dbContext.Customers.AnyAsync(x => x.Id == id);

            if (!exist)
            {
                return NotFound();
            }

            dbContext.Remove(new Customer() { Id = id });

            await dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
