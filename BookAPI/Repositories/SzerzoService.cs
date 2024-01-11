using BookAPI.Models;
using BookAPI.Models.DTOs;

namespace BookAPI.Repositories
{
    public class SzerzoService : SzerzoInterface
    {
        private readonly BookdbContext dbContext;
        public SzerzoService(BookdbContext dbContext)
        {

            this.dbContext = dbContext;
        }
        public async Task<Szerzo> DeleteById(Guid id)
        {

            var szer = dbContext.Szerzos.Where(x => x.Id == id).FirstOrDefault();

            dbContext.Szerzos.Remove(szer);
            await dbContext.SaveChangesAsync();

            return szer;
        }

        public async Task<IEnumerable<Szerzo>> Get()
        {
            return dbContext.Szerzos.ToList();
        }

        public async Task<Szerzo> GetById(Guid id)
        {
            var szer = dbContext.Szerzos.Where(x => x.Id == id).FirstOrDefault();

            return szer;
        }

        public async Task<Szerzo> Post(DTOs.SzerzoCreatedDTO createDTO)
        {
            var szer = new Szerzo
            {

                Id = Guid.NewGuid(),
                Nev = createDTO.Nev,
                Nem = createDTO.Nem,
                NemzId = createDTO.NemzId
            };

            await dbContext.Szerzos.AddAsync(szer);
            await dbContext.SaveChangesAsync();

            return szer;
        }

        public async Task<Szerzo> Put(Guid id, DTOs.SzerzoUpdatedDTO updateDTO)
        {
            var szer = dbContext.Szerzos.Where(x => x.Id == id).FirstOrDefault();

            szer.Nev = updateDTO.Nev;
            szer.Nem = updateDTO.Nem;
            szer.NemzId = updateDTO.NemzId;

            await dbContext.SaveChangesAsync();

            return szer;
        }
    }
}
