namespace CW_4_CS.Classes;

internal struct Date
{
    public int year;
    public int month;
    public int day;

    public Date(int year, int month, int day)
    {
        this.year = year;
        this.month = month;
        this.day = day;
    }

    public override string ToString()
    {
        return $"year: {year}, month: {month}, day: {day}";
    }
}
