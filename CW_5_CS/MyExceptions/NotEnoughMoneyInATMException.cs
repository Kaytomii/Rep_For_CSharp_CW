namespace CW_5_CS.MyExceptions;

internal class NotEnoughMoneyInATMException:Exception
{
    public NotEnoughMoneyInATMException(string mes) : base(mes)
    {

    }
}
