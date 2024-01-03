using System.Globalization;

namespace EntranceRegister;

public static class DateUtils
{
    public static string ToPersianDateTimeString(DateTime dateTime)
    {
        return $"{ToPersianTimeString(dateTime)} {ToPersianDateString(dateTime)}";
    }

    public static string ToPersianDateString(DateTime dateTime)
    {
        var persianCalendar = new PersianCalendar();
        return $"{persianCalendar.GetYear(dateTime)}/{persianCalendar.GetMonth(dateTime):00}/{persianCalendar.GetDayOfMonth(dateTime):00}";
    }

    public static string ToPersianTimeString(DateTime dateTime)
    {
        return dateTime.ToString("HH:mm");
    }

    public static string ToLongPersianDateTimeString(DateTime dateTime)
    {
        return $"{ToPersianTimeString(dateTime)} {ToPersianDayOfWeekString(dateTime.DayOfWeek)} {ToPersianDateString(dateTime)}";
    }

    public static string ToPersianDayOfWeekString(DayOfWeek dayOfWeek)
    {
        return dayOfWeek switch
        {
            DayOfWeek.Saturday => "شنبه",
            DayOfWeek.Sunday => "یک‌شنبه",
            DayOfWeek.Monday => "دوشنبه",
            DayOfWeek.Tuesday => "سه‌شنبه",
            DayOfWeek.Wednesday => "چهارشنبه",
            DayOfWeek.Thursday => "پنج‌شنبه",
            DayOfWeek.Friday => "جمعه",
            _ => string.Empty
        };
    }

    public static DateTime? ParsePersianDate(string text)
    {
        try
        {
            var parts = text.Split('/');
            var calendar = new PersianCalendar();
            return calendar.ToDateTime(Convert.ToInt32(parts[0]), Convert.ToInt32(parts[1]), Convert.ToInt32(parts[2]), 0, 0, 0, 0);
        }
        catch
        {
            return null;
        }
    }
}
