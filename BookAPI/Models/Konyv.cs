using System;
using System.Collections.Generic;

namespace BookAPI.Models;

public partial class Konyv
{
    public Guid Id { get; set; }

    public string Cim { get; set; }

    public int Oldalszam { get; set; }

    public int Kiadev { get; set; }

    public Guid SzerzoId { get; set; }

    public virtual Szerzo? Szerzo { get; set; }
}
