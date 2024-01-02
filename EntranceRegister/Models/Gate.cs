using System.Collections.Generic;

namespace EntranceRegister.Models;

public partial class Gate
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Presence> Presences { get; set; } = new HashSet<Presence>();

    public virtual ICollection<Host> Hosts { get; set; } = new HashSet<Host>();
}