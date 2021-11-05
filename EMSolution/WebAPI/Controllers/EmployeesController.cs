using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.DbServices;
using Services.Entities.Out;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        // GET: api/FoodItems
        [HttpGet]
        public async Task<IEnumerable<SEmployee>> GetFoodItems()
        {
            return await _employeeService.ConsultarAsync();
        }

        // GET: api/FoodItems
        [HttpGet]
        public async Task<IEnumerable<SEmployee>> GetFoodItems(int id)
        {
            return await _employeeService.ConsultarAsyncByID(id);
        }


    }

}
