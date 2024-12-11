abstract class Qso
{

    protected string[] _stateCodes = new string[]
    {
    "AL", "al", "Al", "aL", "AK", "ak", "Ak", "aK", "AZ", "az", "Az", "aZ", "AR", "ar", "Ar", "aR", "CA", "ca", "Ca", "cA", "CO", "co", "Co", "cO", "CT", "ct", "Ct", "cT",
    "DE", "de", "De", "dE","FL", "fl", "Fl", "fL", "GA", "ga", "Ga", "gA", "HI", "hi", "Hi", "hI", "ID", "id", "Id", "iD", "IL", "il", "Il", "iL", "IN", "in", "In", "iN",
    "IA", "ia", "Ia", "iA", "KS", "ks", "Ks", "kS", "KY", "ky", "Ky", "kY", "LA", "la", "La", "lA", "ME", "me", "Me", "mE", "MD", "md", "Md", "mD", "MA", "ma", "Ma", "mA",
    "MI", "mi", "Mi", "mI", "MN", "mn", "Mn", "mN", "MS", "ms", "Ms", "mS", "MO", "mo", "Mo", "mO", "MT", "mt", "Mt", "mT", "NE", "ne", "Ne", "nE", "NV", "nv", "Nv", "nV",
    "NH", "nh", "Nh", "nH", "NJ", "nj", "Nj", "nJ", "NM", "nm", "Nm", "nM", "NY", "ny", "Ny", "nY", "NC", "nc", "Nc", "nC", "ND", "nd", "Nd", "nD", "OH", "oh", "Oh", "oH",
    "OK", "ok", "Ok", "oK",
    "OR", "or", "Or", "oR", "PA", "pa", "Pa", "pA", "RI", "ri", "Ri", "rI", "SC", "sc", "Sc", "sC", "SD", "sd", "Sd", "sD", "TN", "tn", "Tn", "tN", "TX", "tx", "Tx", "tX",
    "UT", "ut", "Ut", "uT", "VT", "vt", "Vt", "vT", "VA", "va", "Va", "vA", "WA", "wa", "Wa", "wA", "WV", "wv", "Wv", "wV", "WI", "wi", "Wi", "wI", "WY", "wy", "Wy", "wY",
    "DX", "dx", "Dx", "dX"
    };

    protected float _frequency;
    protected int _rstRx;
    protected int _rstTx;
    protected string _state = ""; // 2 digit state abrv. (i.e. TX, AZ, ID)
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

        while (_state == "")
        {
            Console.Write("Enter the State of the Recived Station (i.e. AZ, DX) : ");
            string rawInput = Console.ReadLine();
            string firstTwoChars = rawInput.Length >= 2 ? rawInput.Substring(0, 2) : rawInput;

            foreach (string item in _stateCodes)
            {
                if (item == firstTwoChars)
                {
                    _state = item;
                    break;
                }

            }
            if (_state == "")
            {
                Console.Clear();
                Console.Write("State not found! Please retry! \n");
            }
        }
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

    public string returnQso()
    {
        getCallsign();
        string qsoString = ($"Frequency: {_frequency} \nCallsign: {_callsign} \nRX Signal Report: {_rstRx} \nTX Signal Report: {_rstTx} \nState: {_state} \nTime: {_date}");
        return qsoString;
    }

    public Qso()
    {
        setFreq();
        setCallsign();
        setRx();
        setTx();
        setState();
        setTime();
        Console.Clear();
    }

    //  public Qso()
    //  {
    //     this.newQso();
    //  }
}