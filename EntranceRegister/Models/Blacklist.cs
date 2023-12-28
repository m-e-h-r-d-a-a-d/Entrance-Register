using System;
using System.Collections.Generic;

namespace EntranceRegister.Models;

public partial class Blacklist
{
    public Guid PersonId { get; set; }

    public string? Note { get; set; }

    public virtual Person Person { get; set; } = null!;
}
