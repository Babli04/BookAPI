using BookAPI.Models;
using BookAPI.Models.DTOs;
using BookAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static BookAPI.Models.DTOs.DTOs;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KonyvController : ControllerBase
    {

        private readonly KonyvInterface konyvInterface;
        public KonyvController(KonyvInterface konyvInterface)
        {
            this.konyvInterface = konyvInterface;
        }

        [HttpPost]
        public async Task<ActionResult<Konyv>> Post(KonyvCreatedDTO createDTO)
        {

            return StatusCode(201, await konyvInterface.Post(createDTO));
        }

        [HttpGet]
        public async Task<IEnumerable<Konyv>> Get()
        {

            return await konyvInterface.Get();
        }

        [HttpGet("{id}")]
        public async Task<Konyv> Get(Guid id)
        {

            return await konyvInterface.GetById(id);
        }

        [HttpPut("{id}")]
        public async Task<Konyv> Put(Guid id, KonyvUpdatedDTO updateDTO)
        {

            return await konyvInterface.Put(id, updateDTO);
        }

        [HttpDelete("{id}")]
        public async Task<Konyv> Delete(Guid id)
        {
            return await konyvInterface.DeleteById(id);
        }
    }
}
