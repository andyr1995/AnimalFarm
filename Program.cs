namespace AnimalExampleCSharp;

public class program
{

    public static void Main(string[] args)
    {

        Bat Billy = new Bat();
        Billy.Name = "Billy";
        Console.WriteLine("Hi i'm " + Billy.Name+ " The Bat");
        Billy.Age = 5;
        Console.WriteLine("I am currently "+ Billy.Age);
        Console.WriteLine(Billy.Poo());
        Billy.flight();
        Billy.crashing();
        Billy.die(5);
        Console.WriteLine(" ");

        Elephant Dumbo = new Elephant();
        Dumbo.Name = "Dumbo";
        Console.WriteLine("Hi i'm  " + Dumbo.Name);
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
        Tony.Drowning();
        Tony.die(21);
        Console.WriteLine(" ");

        Salmon Sally = new Salmon();
        Sally.Name = "Sally";
        Console.WriteLine("I am a Salmon called "+ Sally.Name);
        Console.WriteLine(Sally.Poo());
        Sally.swimming();
        Sally.Diving();
        Sally.Jumping();
        Sally.Drowning();
        Sally.die(1);
        Console.WriteLine(" ");

        Sloth Simon = new Sloth();
        Simon.Name = "Simon";
        Console.WriteLine("I am a Sloth called " + Simon.Name);
        Console.WriteLine(Simon.Poo());
        Simon.moveForward();
        Simon.moveBackwards();
        Simon.swimming();
        Simon.Diving();
        Simon.Jumping();
        Simon.Drowning();
        Simon.die(17);
        Console.WriteLine(" ");



    }
}