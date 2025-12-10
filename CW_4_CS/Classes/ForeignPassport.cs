namespace CW_4_CS.Classes;

internal class ForeignPassport
{
    private int passport_number;
    private string? LFM;
    private CW_4_CS.Classes.Date date;

    public ForeignPassport(int passport_number, string? LFM, CW_4_CS.Classes.Date date)
    {
        this.passport_number = passport_number;
        this.LFM = LFM;
        this.date = date;
    }

    public override string ToString()
    {
        return $"Passport number: {passport_number}, LFM: {LFM}, date: {date}, ";
    }
}
