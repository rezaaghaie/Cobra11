using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cobra11.Controllers
{
    [Route("api/console")]
    public class ConsoleController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public async Task<String> Get()
        {
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Test From a .net core 'Dockerized' App");
            Console.ResetColor();

            return "Check Console, Search for thos phrase : Test From a .net core 'Dockerized' App";
        }
    }
}
