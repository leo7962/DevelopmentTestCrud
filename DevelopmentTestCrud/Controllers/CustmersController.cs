using AutoMapper;
using DevelopmentTestCrud.Contexts;
using DevelopmentTestCrud.Dtos;
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

        [HttpGet]
        public async Task<ActionResult<List<CustomerDto>>> Get()
        {
            var entity = await dbContext.Customers.ToListAsync();
            var dtos = mapper.Map<List<CustomerDto>>(entity);
            return dtos;
        }
    }
}
