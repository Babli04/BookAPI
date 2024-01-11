using BookAPI.Models;
using BookAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static BookAPI.Models.DTOs.DTOs;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NemzetisegController : ControllerBase
    {
        private readonly NemzetisegInterface nemzetisegInterface;
        public NemzetisegController(NemzetisegInterface nemzetisegInterface)
        {
            this.nemzetisegInterface = nemzetisegInterface;
        }

        [HttpPost]
        public async Task<ActionResult<Nemzetiseg>> Post(NemzetisegCreatedDTO createDTO)
        {

            return StatusCode(201, await nemzetisegInterface.Post(createDTO));
        }

        [HttpGet]
        public async Task<IEnumerable<Nemzetiseg>> Get()
        {

            return await nemzetisegInterface.Get();
        }

        [HttpGet("{id}")]
        public async Task<Nemzetiseg> Get(Guid id)
        {

            return await nemzetisegInterface.GetById(id);
        }

        [HttpPut("{id}")]
        public async Task<Nemzetiseg> Put(Guid id, NemzetisegUpdatedDTO updateDTO)
        {

            return await nemzetisegInterface.Put(id, updateDTO);
        }

        [HttpDelete("{id}")]
        public async Task<Nemzetiseg> Delete(Guid id)
        {
            return await nemzetisegInterface.DeleteById(id);
        }
    }
}
