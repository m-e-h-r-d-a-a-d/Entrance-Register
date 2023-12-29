namespace EntranceRegister.Models;

public partial class Presence
{
    public Guid Id { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public Guid PersonId { get; set; }

    public byte[]? Photo { get; set; }

    public string RegistrarUsername { get; set; } = null!;

    public Guid? HostId { get; set; }

    public Guid GateId { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual Host Host { get; set; } = null!;

    public virtual User Registrar { get; set; } = null!;

    public virtual Gate Gate { get; set; } = null!;
}