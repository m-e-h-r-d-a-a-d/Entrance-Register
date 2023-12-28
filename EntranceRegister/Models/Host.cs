using System;
using System.Collections.Generic;

namespace EntranceRegister.Models;

public partial class Host
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public Guid? GateId { get; set; }
}
