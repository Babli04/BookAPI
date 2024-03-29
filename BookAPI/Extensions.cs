﻿using BookAPI.Models;
using static BookAPI.Models.DTOs.DTOs;

namespace BookAPI
{
    public static class Extensions
    {
        public static KonyvDTO AsDTO(this Konyv konyv)
        {
            return new(konyv.Id, konyv.Cim, konyv.Oldalszam, konyv.Kiadev, konyv.SzerzoId);
        }

        public static SzerzoDTO AsDTO(this Szerzo szerzo)
        {
            return new(szerzo.Id, szerzo.Nev, szerzo.Nem, szerzo.NemzId);
        }

        public static NemzetisegDTO AsDTO(this Nemzetiseg nemzetiseg)
        {
            return new(nemzetiseg.Id, nemzetiseg.SzerzoNemz);
        }
    }
}
