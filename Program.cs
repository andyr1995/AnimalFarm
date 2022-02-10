namespace AnimalExampleCSharp;

public class program
{

    public static void Main(string[] args)
    {

        Bat myBat = new Bat();
        Console.WriteLine(myBat.Age);
        Console.WriteLine(myBat.Poo());
        myBat.flight();
        myBat.crashing();
        Console.WriteLine(" ");

        Elephant Dumbo = new Elephant();
        Console.WriteLine("I am Dumbo the Elephant");
        Console.WriteLine(Dumbo.Poo());
        Dumbo.flight();
        Dumbo.crashing();
        Dumbo.die(65);
        Console.WriteLine(" ");
        

        Tiger Tony = new Tiger();
        Tony.Name = "Tony";
        Console.WriteLine("The names "+ Tony.Name );
        Console.WriteLine(Tony.Poo());
        Tony.swimming();
        Tony.Diving();
        Tony.Jumping();
        Tony.die(10);
        Console.WriteLine(" ");

        Salmon Sally = new Salmon();
        Sally.Name = "Sally";
        Console.WriteLine("I am a Salmon called "+ Sally.Name);
        Console.WriteLine(Sally.Poo());
        Sally.swimming();
        Sally.Diving();
        Sally.Drowning();
        Sally.die(1);
        Console.WriteLine(" ");



    }
}