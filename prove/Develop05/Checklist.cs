class Checklist : Goal 
{
    //A goal with multiple items within.

    //Attrubutes:
    private int _TimesCompleted = 0; 
    private int _TimesToComplete = 0; //how many times does complete need to be set for all items to be checked off?

    protected override int SetPoints()
      {
           // Set the point value
           Console.Write("How many points is each item in this Goal worth?");
            int _PointValue = int.Parse(Console.ReadLine()); //returns an integer
            return _PointValue;
        }

public void AddBonusPoints()
{
  ;
}

protected override bool SetComplete()
{
    //set to true if completed.
  ++_TimesCompleted;
  bool _Done;

  if (_TimesToComplete == _TimesCompleted) //If number of goals is completed,
    {
      _Done = true;
    }
  else
    {
      _Done = false;
    }
  return _Done;    
}

public override int returnPoints()
{
  return _PointValue * _TimesCompleted; 
}

}