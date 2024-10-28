public class References
{
    private string book = "blank";
    private int chapter = 0;
    private string verses = "0";
    private Contents content = new Contents();



    private void GetRef()
    {
        Console.Write("Please enter the book that your scripture is in: ");
        book = Console.ReadLine(); //assigns the book 
        Console.WriteLine("Now ender the chapter:");
        chapter = int.Parse(Console.ReadLine());

        Console.WriteLine("Now ender the verse or verses:");
        verses = Console.ReadLine();
         //inits actual text
    }

    private void getContents(){
         //New contents of the reffered scripture.
        content.Fill_list(); //prompts user for scripture.
    }


    public void initRef(){
        GetRef();
        getContents();
    }

    public void display_content(){
        Console.WriteLine($"{book} {chapter} {verses}");
        content.display_content();
    }

    public void display_volitile()
    {
        content.display_volitile();
    }

    public void scramble()
    {
        content.scramble();
        Console.Clear();
        display_volitile();
    }
}