using System.IO.Pipes;

class Eternal : Goal
{
    private int _TimesCompleted = 0;
    
    protected override bool SetComplete()
    {
        ++_TimesCompleted;
        return _Done;         
    }

    protected override int SetPoints()
{
    Console.Write("How many points is this goal worth?: ");
    int _pointValue = int.Parse(Console.ReadLine());

    return _pointValue;
}

public override int returnPoints()
{
    return _PointValue * _TimesCompleted;
}

}