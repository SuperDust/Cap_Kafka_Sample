using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore.CAP;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Dapper;

namespace Services_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Service1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromServices] ICapPublisher capPublish, [FromServices] IConfiguration configuration)
        {
            using SqlConnection connection = new SqlConnection(configuration.GetConnectionString("Cap"));
            connection.Open();
            using (IDbTransaction transaction = connection.BeginTransaction(capPublish)) {
                try
                {
                    capPublish.Publish("Service2.hello", "分布式事务");        
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }
         

            
            return Ok();
        }

    }
}
