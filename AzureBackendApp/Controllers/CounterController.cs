using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AzureBackendApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CounterController : ControllerBase
    {
        private static Counter.Domain.Counter _counter = new Counter.Domain.Counter();
        [HttpGet]
        public int Get()
        {
            return _counter.Get();
        }

        // POST api/<CounterController>
        [HttpPost("Increment")]
        public void Increment()
        {
            _counter.Increment();
        }

        [HttpPost("Decrement")]
        public void Decrement()
        {
            _counter.Decrement();
        }

        // DELETE api/<CounterController>/5
        [HttpDelete]
        public void Reset()
        {
            _counter.Restart();
        }
    }
}
