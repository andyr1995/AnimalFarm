namespace AnimalExampleCSharp;

public class program
{

    public static void Main(string[] args)
    {

        Console.WriteLine("Hello, World!");
        Bat myBat = new Bat();
        
        Console.WriteLine(myBat.ToString());
        Console.WriteLine(myBat.poo());
        myBat.flight();
        myBat.crashing();
   
        myBat.Age++;
        Console.WriteLine(myBat.Age);
    }
}