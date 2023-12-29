namespace EntranceRegister.Models;

public partial class Person
{
    public string Title => (Gender != null ? (Gender.Value ? "خانم " : "آقای ") : string.Empty) + Fullname;

    public override string ToString()
    {
        return Title;
    }
}
