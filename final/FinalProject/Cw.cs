class Cw : Qso
{
        protected override void setRx()
    {
        Console.Write("what is the other station's 3 digit RST (i.e 599) : ");
        _rstRx = int.Parse(Console.ReadLine());
    }

    protected override void setTx()
    {
        Console.Write("what is the your station's 3 digit RST (i.e 599) : ");
        _rstTx = int.Parse(Console.ReadLine());
    }
}