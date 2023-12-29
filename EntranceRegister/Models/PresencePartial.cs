namespace EntranceRegister.Models;

public partial class Presence
{
    public string StartDatePersian => DateUtils.ToPersianDateString(StartDate);

    public string StartTime => DateUtils.ToPersianTimeString(StartDate);

    public string StartDateTimePersian => DateUtils.ToPersianDateTimeString(StartDate);

    public string EndDatePersian => EndDate.HasValue ? DateUtils.ToPersianDateString(EndDate.Value) : string.Empty;

    public string EndTime => EndDate.HasValue ? DateUtils.ToPersianTimeString(EndDate.Value) : string.Empty;

    public string EndDateTimePersian => EndDate.HasValue ? DateUtils.ToPersianDateTimeString(EndDate.Value) : string.Empty;

    public string HostName => Host.Name;

    public string? GateName => Gate.Name;

    public string PersonTitle => Person.Title;

    public string PersonFullname => Person.Fullname;
}