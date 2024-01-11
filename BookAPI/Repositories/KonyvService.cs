using BookAPI.Models;
using BookAPI.Models.DTOs;

namespace BookAPI.Repositories
{
    public class KonyvService : KonyvInterface
    {
        private readonly BookdbContext dbContext;
        public KonyvService(BookdbContext dbContext)
        {

            this.dbContext = dbContext;
        }
        public async Task<Konyv> DeleteById(Guid id)
        {

            var book = dbContext.Konyvs.Where(x => x.Id == id).FirstOrDefault();

            dbContext.Konyvs.Remove(book);
            await dbContext.SaveChangesAsync();

            return book;
        }

        public async Task<IEnumerable<Konyv>> Get()
        {
            return dbContext.Konyvs.ToList();
        }

        public async Task<Konyv> GetById(Guid id)
        {
            var book = dbContext.Konyvs.Where(x => x.Id == id).FirstOrDefault();

            return book;
        }

        public async Task<Konyv> Post(DTOs.KonyvCreatedDTO createDTO)
        {
            var book = new Konyv
            {

                Id = Guid.NewGuid(),
                Cim = createDTO.Cim,
                Kiadev = createDTO.Kiadev,
                Oldalszam = createDTO.Oldalszam,
                SzerzoId = createDTO.SzerzoId
            };

            await dbContext.Konyvs.AddAsync(book);
            await dbContext.SaveChangesAsync();

            return book;
        }

        public async Task<Konyv> Put(Guid id, DTOs.KonyvUpdatedDTO updateDTO)
        {
            var book = dbContext.Konyvs.Where(x => x.Id == id).FirstOrDefault();

            book.Cim = updateDTO.Cim;
            book.Kiadev = updateDTO.Kiadev;
            book.Oldalszam = updateDTO.Oldalszam;
            book.SzerzoId = updateDTO.SzerzoId;

            await dbContext.SaveChangesAsync();

            return book;
        }
    }
}
