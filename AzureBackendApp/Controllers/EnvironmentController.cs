using Microsoft.AspNetCore.Mvc;
using System.Collections;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AzureBackendApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnvironmentController : ControllerBase
    {
        // GET: api/<EnvironmentController>
        [HttpGet("Variables")]
        public IDictionary Get()
        {
            return Environment.GetEnvironmentVariables();
        }
    }
}
