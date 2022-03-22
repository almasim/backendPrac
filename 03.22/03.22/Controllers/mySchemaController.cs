using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using _03._22.Models;

namespace _03._22.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mySchemaController : ControllerBase
    {
        [HttpGet]

        public JsonResult Get()
        {
            List<Employee> employes = new List<Employee>();
            using (var context = new schemaContext())
            {
                try
                {
                    return new JsonResult(context.Employees.Select(x => new Employee() {
                        employeeNumber = x.employeeNumber,
                        lastName = x.lastName,
                        firstName = x.firstName,
                        extension = x.extension,
                        email = x.email,
                        officeCode = x.officeCode,
                        reportsTo = x.reportsTo,
                        jobTitle = x.jobTitle
                    }).ToList()) ;
                }
                catch (System.Exception ex)
                {

                    return new JsonResult(ex.Message);
                }
            }
        }
        [HttpPost]
        public JsonResult Post(Employee user) 
        {
            using (var context = new schemaContext())
            {
                try
                {
                    context.Employees.Add(user);
                    context.SaveChanges();
                    return new JsonResult("Employee felvétele megtörtént.");
                }
                catch (System.Exception ex)
                {

                    return new JsonResult(ex.Message);
                }
            }
        }
        [HttpPut]
        public JsonResult Put(Employee User)
        {
            using (var context = new schemaContext())
            {
                try
                {
                    context.Employees.Update(User);
                    context.SaveChanges();
                    return new JsonResult("Az adatok módosítása megtörtént.");
                }
                catch (System.Exception ex)
                {

                    return new JsonResult(ex.Message);
                }
            }
        }

    }
}
