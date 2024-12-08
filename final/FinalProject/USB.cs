class USB : Qso
{
    protected override void setRx()
    {
        Console.Write("what is the other station's RST (i.e 59) : ");
        _rstRx = int.Parse(Console.ReadLine());
    }

    protected override void setTx()
    {
        Console.Write("what is the your station's RST (i.e 59) : ");
        _rstTx = int.Parse(Console.ReadLine());
    }
}