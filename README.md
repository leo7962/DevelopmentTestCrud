# DevelopmentTestCrud

Es un proyecto desarrollado con Dotnet Core y Angular, en el que usé las librerías para integrar los diferentes framworks para que estos corran juntos al realizar la ejecución.

el proyecto se utilizó librerías de Microsoft para la gestión y el control del scafolding, realizando AutoMapper para la sincronización de mi modelo de persistencia y también aplicando inyección de dependencias para generar mi modelo de base de datos con la ayuda de la librería de _Microsoft.EntityFrameworkCore.Tools_ para la migración y la actualización de mi base de datos.

# Consulta de Apis:

puede consultar el nombre de mis Endpoints de la siguiente manera _https://localhost:44394/swagger/index.html_ Con swagger puedes consultar y ver la estructura de cada endpoint realizado, de esta manera puede hacer un test rápido sin la necesidad de utilizar Postman, haciendo que esta interfaz UI sea la consulta de cada endpoint.

# Trabajo de Backend

Desempeñé un patrón llamado patrón repositorio, este me ayuda a gestionar fácilmente mi estructura de proyecto manteniendo una base solida para este pequeño proyecto y persistencia con mi base de datos sin comprometer directamente cada modelo realizado en mi bosquejo desarrollado.
