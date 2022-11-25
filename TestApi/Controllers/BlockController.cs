using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TestApi.Entities;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlockController
    {
        [EnableCors("MyPolicy")]
        [HttpGet]
        public IEnumerable<Block> Get()
        {
            return Enumerable.Range(1, 3).Select(i => new Block(i, "some title", "some body")).ToArray();
        }
    }
}
