using MVCUsingWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCUsingWebAPI.Controllers
{
    public class SubcribersController : ApiController
    {

        DataEntitiesContext dbContext = new DataEntitiesContext();
        // GET api/values
     public IEnumerable<Employee> Get()
        {
            return dbContext.Employees.ToList();
            //return new string[] { "value1", "value2" };
        }

        
    }
}
