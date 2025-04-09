namespace IBASEmployeeService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using IBASEmployeeService.Models;
    using System.Collections.Generic;
    using System.Linq;

    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        List<Employee> employees = new List<Employee>() {
            new Employee() {
                Id = "21",
                Name = "Mette Bangsbo",
                Email = "meba@ibas.dk",
                Department = new Department() {
                    Id = 1,
                    Name = "Salg"
                }
            },
            new Employee() {
                Id = "22",
                Name = "Hans Merkel",
                Email = "hame@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
                Id = "23",
                Name = "Karsten Mikkelsen",
                Email = "kami@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
                Id = "24",
                Name = "Benjamin",
                Email = "vman@mail.com",
                Department = new Department() {
                    Id = 3,
                    Name = "it"
                }
            },
            new Employee() {
                Id = "25",
                Name = "Mathias",
                Email = "vman@mail.com2",
                Department = new Department() {
                    Id = 4,
                    Name = "Kantine"
                }
            }
        };

        [HttpGet("GetSalgEmployees")]
        public IEnumerable<Employee> GetSalgEmployees()
        {
            // Filter employees with Department.Id == 1 (Salg)
            var salgEmployees = employees.Where(e => e.Department.Id == 1).ToList();
            return salgEmployees;
        }

        [HttpGet("GetKantineEmployees")]
        public IEnumerable<Employee> GetKantineEmployees()
        {
            // Filter employees with Department.Id == 4 (Kantine)
            var kantineEmployees = employees.Where(e => e.Department.Id == 4).ToList();
            return kantineEmployees;
        }
    }
}
