using System.ComponentModel.DataAnnotations;
//this class works to hide the verses. 
public class Scriptures
{
    References ref1 = new References();
     


public void init()
{
    ref1.initRef(); //init references, and scripture content

}




public void display_scripture() //call the display scripture function in contents and reference
{
    ref1.display_content();
}

public void display_changed()
{
    ref1.display_volitile();
}

public void remove_word()
{
    ref1.scramble(); //remove 3 words, clear console, display changed verse.
}


}
