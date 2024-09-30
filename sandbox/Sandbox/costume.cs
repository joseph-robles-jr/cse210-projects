using System.Xml.XPath;

class Costume
{
    //attributes (Member Variabes). MUST BE MADE PUBLIC TO ALLOW OTHER FILES TO USE IT. 
    public string headwear;
    public string gloves;
    public string shoes;
    public string upperGarment;
    public string lowerGarment;
    public string accessory;



    //behaviors MUST BE MADE PUBLIC 
    public void ShowWardrobe() 
    {
        string result = "";
        result += $"Head: {headwear}\n";
        result += $"Hands: {gloves}\n";
        result += $"Feet: {shoes}\n";
        result += $"Torso: {upperGarment}\n";
        result += $"Legs: {lowerGarment}\n";
        result += $"Accessory: {accessory}\n";
        Console.WriteLine(result);
    }


}