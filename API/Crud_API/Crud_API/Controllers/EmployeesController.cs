using Crud_API.Data;
using Crud_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Crud_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly CrudAPIDBContext _crudAPIDBContext;

        public EmployeesController(CrudAPIDBContext crudAPIDBContext)
        {
            _crudAPIDBContext = crudAPIDBContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _crudAPIDBContext.Employees.ToListAsync();
            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employeeRequest)
        {
            employeeRequest.Id = Guid.NewGuid();
            await _crudAPIDBContext.AddAsync(employeeRequest);
            await _crudAPIDBContext.SaveChangesAsync();
            return Ok(employeeRequest);
        }
    }
}
