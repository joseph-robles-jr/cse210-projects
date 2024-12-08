using System.Dynamic;
using System.Runtime.CompilerServices;

abstract class Qso 
{
   protected float _frequency;
   protected int _rstRx;
   protected int _rstTx;
   protected string _state; // 2 digit state abrv. (i.e. TX, AZ, ID)
   protected string _callsign; //callsign of rx station

   protected string _date; //set with getDateTime()

    protected abstract void setRx();
    protected abstract void setTx();
   
    protected void setFreq() //get the frequency and assign it to _frequesncy
    {
        Console.Write("Enter the frequency (i.e. 28.445): ");
        _frequency = float.Parse(Console.ReadLine());   
    }

    protected void setState() 
    {
        Console.Write("Enter the State of the Recived Station (i.e. AZ) : ");
        _state = Console.ReadLine();
    }

    protected void setCallsign()
    {
        Console.Write("Callsign of Recived station (i.e. K7BYI) : ");
        _callsign = Console.ReadLine();
    }
    
    protected void setTime() //returns the date and time for the log
    {
    DateTime now = DateTime.UtcNow; // Format the DateTime object to the desired format 
    _date = now.ToString("dd, MMMM, yyyy - HH:mm:ss"); // Output the formatted date
    }
   
 
    protected float getFreq()
    {
        return _frequency;
    }

    protected int getTx()
    {
        return _rstTx;
    }

    protected int getRx()
    {
        return _rstRx;
    }

    protected string getState()
    {
        return _state;
    }

    protected string getCallsign()
    {
        return _callsign;
    }

    protected string getTime()
    {
        return _date;
    }

    public void listQso()
    {
        getCallsign();
        Console.WriteLine($"Frequency: {_frequency} \nCallsign: {_callsign} \nRX Signal Report: {_rstRx} \nTX Signal Report: {_rstTx} \nTime: {_date}" );

    }

     public void newQso()
     {
        setFreq();
        setCallsign();
        setRx();
        setTx();
        setState();
        setTime();
     }
}