using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AzureBackendApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CounterController : ControllerBase
    {
        private static int _counter = 0;
        [HttpGet]
        public int Get()
        {
            return _counter;
        }

        // POST api/<CounterController>
        [HttpPost("Increment")]
        public void Increment()
        {
            _counter += 1;
        }

        [HttpPost("Decrement")]
        public void Decrement()
        {
            if (_counter <= 0)
                throw new Exception("Counter can not have negative value");

            _counter -= 1;
        }

        // DELETE api/<CounterController>/5
        [HttpDelete("{id}")]
        public void Reset()
        {
            _counter = 0;
        }
    }
}
