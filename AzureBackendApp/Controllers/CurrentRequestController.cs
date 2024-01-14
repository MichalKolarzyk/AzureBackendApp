using Microsoft.AspNetCore.Mvc;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AzureBackendApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrentRequestController : ControllerBase
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public CurrentRequestController(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        // GET: api/<CurrentRequestController>
        [HttpGet("RemoteIpAddress")]
        public IPAddress Get()
        {
            if (_contextAccessor.HttpContext?.Connection.RemoteIpAddress == null)
                throw new Exception("Empty http context");

            return _contextAccessor.HttpContext.Connection.RemoteIpAddress;
        }
    }
}
