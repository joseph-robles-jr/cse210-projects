using System.Reflection;

class SimpleGoal : Goal
{
// Should be completed once

protected override bool SetComplete()
{
    //set to true if completed.
    bool _Done = true;
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
    if (_Done == true)
        {
            return _PointValue;
        }
    else
    {
        return 0;
    }
}


}