using BookAPI.Models;
using BookAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static BookAPI.Models.DTOs.DTOs;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SzerzoController : ControllerBase
    {
        private readonly SzerzoInterface szerzoInterface;
        public SzerzoController(SzerzoInterface szerzoInterface)
        {
            this.szerzoInterface = szerzoInterface;
        }

        [HttpPost]
        public async Task<ActionResult<Szerzo>> Post(SzerzoCreatedDTO createDTO)
        {

            return StatusCode(201, await szerzoInterface.Post(createDTO));
        }

        [HttpGet]
        public async Task<IEnumerable<Szerzo>> Get()
        {

            return await szerzoInterface.Get();
        }

        [HttpGet("{id}")]
        public async Task<Szerzo> Get(Guid id)
        {

            return await szerzoInterface.GetById(id);
        }

        [HttpPut("{id}")]
        public async Task<Szerzo> Put(Guid id, SzerzoUpdatedDTO updateDTO)
        {

            return await szerzoInterface.Put(id, updateDTO);
        }

        [HttpDelete("{id}")]
        public async Task<Szerzo> Delete(Guid id)
        {
            return await szerzoInterface.DeleteById(id);
        }
    }
}
