public class Fraction{

    private int _fraction_top;
    private int _fraction_bottom;

    public Fraction(){
        _fraction_top = 1;
        _fraction_bottom = 1;
    }   

    public Fraction(int new_top){
        _fraction_top = new_top;
        _fraction_bottom = 1;
    }

    public Fraction(int new_top, int new_bottom){
        _fraction_top = new_top;
        _fraction_bottom = new_bottom;
    }

    public string GetFractionString()
    {
        string string_fraction;
        string_fraction = (_fraction_top + "/" + _fraction_bottom);
        return string_fraction;
    }

    public double GetDecimalValue()
    {
        double _asADecimal;
        _asADecimal = _fraction_top / _fraction_bottom;

        return _asADecimal;
    }

    public void SetFractionTop(){
        Console.Write("Please enter the top number of the fraction: ");
        _fraction_top = int.Parse(Console.ReadLine());    
    }

    public int GetFractionTop(){
        return _fraction_top;
    }

    public void SetFractionBottom(){
        Console.Write("Please enter the Bottom number of the fraction: ");
        _fraction_bottom = int.Parse(Console.ReadLine());    
    }

    public int GetFractionBottom(){
        return _fraction_bottom;
    }








}