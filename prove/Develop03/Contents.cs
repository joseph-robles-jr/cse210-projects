using System.ComponentModel;
using System.Data;
using System.Resources;
using System.Runtime.CompilerServices;

public class Contents
{
    List<string> content = new List<string>(); //TO hold the whole stripture
    List<string> volitile_content = new List<string>(); // to hold the CHANGED scripture w/ blanks
    private int words_removed = 0;
    private int word_count = 0;


    //Constructor
   public void Fill_list() //innitialize both strings with the complete scripture
   {
      get_content(); // fill content list
      get_volitile_content(); //Fill volitaile with same data.
   }

    //methods

    private void get_content() //rebuild the "content" list
    {
        Console.WriteLine("Please enter the text of the scrpipture!");
        string scripture_input = Console.ReadLine();

        string[] wordArray = scripture_input.Split(' '); //splits at eact space.  
        for (int i = 0; i < wordArray.Length; i++) 
        {
            content.Add(wordArray[i]); // add each word in order. 
        }
    }

    private void get_volitile_content() //rebuild the "volitile_content" list
    {
        volitile_content = content; 
        words_removed = 0;
    }

    public void display_content()
    {
        string full_verse = string.Join(" ", content);

        Console.Write(full_verse);
    }

    public void display_volitile(){
        string changed_verse = string.Join(" ", volitile_content);

        Console.Write(changed_verse);

    }

    public string change_volitile(int numbe_of_words_to_delete) // 
    {
        

        return "zero"; //return the volitile list in a string
    }

    public void scramble() //remove 3 words from the list
    {
        word_count = content.Count;
        Random random = new Random();

        int i = 0; 
        if (word_count >= 3)
        {
            while (i != 3)
            {
            word_count = content.Count;
            int randomNumber = random.Next(0, word_count -1  - words_removed); //-1 accounts for array staring at 0

            volitile_content[randomNumber] = "______"; // replace word with blank word
            words_removed = ++words_removed;
            ++i;
            }
        }
        else if( word_count <3 & word_count >=1) 
        {
            int randomNumber = random.Next(0, ((word_count -1 ) - words_removed)); //-1 accounts for array staring at 0

            volitile_content[randomNumber] = "______"; // replace word with blank word
            words_removed = ++words_removed;
            ++i;
        }
        else
        {
    
        }
    }   
}