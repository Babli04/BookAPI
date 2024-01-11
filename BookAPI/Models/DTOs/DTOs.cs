namespace BookAPI.Models.DTOs
{
    public class DTOs
    {
        public record SzerzoDTO(Guid Id, string Nev, string Nem, Guid NemzId);
        public record SzerzoCreatedDTO(string Nev, string Nem, Guid NemzId);
        public record SzerzoUpdatedDTO(string Nev, string Nem, Guid NemzId);
        public record KonyvDTO(Guid Id, string Cim, int Oldalszam, int Kiadev, Guid SzerzoId);
        public record KonyvCreatedDTO(string Cim, int Oldalszam, int Kiadev, Guid SzerzoId);
        public record KonyvUpdatedDTO(string Cim, int Oldalszam, int Kiadev, Guid SzerzoId);
        public record NemzetisegDTO(Guid Id, string SzerzoNemz);
        public record NemzetisegCreatedDTO(string SzerzoNemz);
        public record NemzetisegUpdatedDTO(string SzerzoNemz);
    }
}
