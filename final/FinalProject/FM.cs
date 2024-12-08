class FM : Qso
{
        protected override void setRx()
    {
        
        _rstRx = 00;
    }

    protected override void setTx()
    {
        _rstTx = 00;;
    }
}