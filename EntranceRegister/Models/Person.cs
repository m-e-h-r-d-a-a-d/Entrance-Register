using System;
using System.Collections.Generic;

namespace EntranceRegister.Models;

public partial class Person
{
    public Guid Id { get; set; }

    public string Fullname { get; set; } = null!;

    public bool? Gender { get; set; }

    public string? NationalNumber { get; set; }

    public virtual Blacklist? Blacklist { get; set; }

    public virtual ICollection<Presence> Presences { get; set; } = new List<Presence>();
}
