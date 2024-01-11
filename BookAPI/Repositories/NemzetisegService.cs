using BookAPI.Models;
using BookAPI.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Repositories
{
    public class NemzetisegService : NemzetisegInterface
    {
        private readonly BookdbContext dbContext;
        public NemzetisegService(BookdbContext dbContext)
        {

            this.dbContext = dbContext;
        }
        public async Task<Nemzetiseg> DeleteById(Guid id)
        {

            var nem = dbContext.Nemzetisegs.Where(x => x.Id == id).FirstOrDefault();

            dbContext.Nemzetisegs.Remove(nem);
            await dbContext.SaveChangesAsync();

            return nem;
        }

        public async Task<IEnumerable<Nemzetiseg>> Get()
        {
            return dbContext.Nemzetisegs.ToList();
        }

        public async Task<Nemzetiseg> GetById(Guid id)
        {
            var nem = dbContext.Nemzetisegs.Where(x => x.Id == id).FirstOrDefault();

            return nem;
        }

        public async Task<Nemzetiseg> Post(DTOs.NemzetisegCreatedDTO createDTO)
        {
            var nem = new Nemzetiseg
            {

                Id = Guid.NewGuid(),
                SzerzoNemz = createDTO.SzerzoNemz
            };

            await dbContext.Nemzetisegs.AddAsync(nem);
            await dbContext.SaveChangesAsync();

            return nem;
        }

        public async Task<Nemzetiseg> Put(Guid id, DTOs.NemzetisegUpdatedDTO updateDTO)
        {
            var nem = dbContext.Nemzetisegs.Where(x => x.Id == id).FirstOrDefault();

            nem.SzerzoNemz = updateDTO.SzerzoNemz;

            await dbContext.SaveChangesAsync();

            return nem;
        }
    }
}
