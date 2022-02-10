namespace AnimalExampleCSharp;

public class program
{

    public static void Main(string[] args)
    {

        Console.WriteLine("Please state age of Bat");
        int batAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Please state name of Bat");
        String batName = Console.ReadLine();
        Console.WriteLine("Please state species of Bat");
        String batSpecies = Console.ReadLine();
        Console.WriteLine(" ");
        Bat newBat = new Bat(batName, batAge , batSpecies);
        Console.WriteLine(newBat.Poo());      
        newBat.flight();
        newBat.crashing();
        newBat.die(20);
        Console.WriteLine(" ");


        Console.WriteLine("Please state age of Elephant");
        int ElephantAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Please state name of Elephant");
        String ElephantName = Console.ReadLine();
        Console.WriteLine("Please state species of Elephant");
        String ElephantSpecies = Console.ReadLine();
        Elephant newElephant = new Elephant(ElephantName, ElephantAge, ElephantSpecies);
        Console.WriteLine(newElephant.Poo());
        newElephant.flight();
        newElephant.crashing();
        newElephant.die(65);
        Console.WriteLine(" ");


        Console.WriteLine("Please state age of Bat");
        int Age = int.Parse(Console.ReadLine());
        Console.WriteLine("Please state name of Bat");
        String Name = Console.ReadLine();
        Console.WriteLine("Please state species of Bat");
        String Species = Console.ReadLine();
        Tiger Tony = new Tiger("Tony" ,21 ,"Siberian Tiger");
        Console.WriteLine(Tony.Poo());
        Tony.swimming();
        Tony.Diving();
        Tony.Jumping();
        Tony.Drowning();
        Tony.die(21);
        Console.WriteLine(" ");


        Console.WriteLine("Please state age of Bat");
        int Age = int.Parse(Console.ReadLine());
        Console.WriteLine("Please state name of Bat");
        String Name = Console.ReadLine();
        Console.WriteLine("Please state species of Bat");
        String Species = Console.ReadLine();
        Salmon Sally = new Salmon();
        Console.WriteLine(Sally.Poo());
        Sally.swimming();
        Sally.Diving();
        Sally.Jumping();
        Sally.Drowning();
        Sally.die(1);
        Console.WriteLine(" ");


        Console.WriteLine("Please state age of Bat");
        int Age = int.Parse(Console.ReadLine());
        Console.WriteLine("Please state name of Bat");
        String Name = Console.ReadLine();
        Console.WriteLine("Please state species of Bat");
        String Species = Console.ReadLine();
        Sloth Simon = new Sloth("Simon", 15 ,"Pygmy 3-toed Sloth");
        Console.WriteLine(Simon.Poo());
        Simon.moveForward();
        Simon.moveBackwards();
        Simon.swimming();
        Simon.Diving();
        Simon.Jumping();
        Simon.Drowning();
        Simon.die(17);
        Console.WriteLine(" ");


        Console.WriteLine("Please state age of Bat");
        int Age = int.Parse(Console.ReadLine());
        Console.WriteLine("Please state name of Bat");
        String Name = Console.ReadLine();
        Console.WriteLine("Please state species of Bat");
        String Species = Console.ReadLine();
        Eagle Elliot = new Eagle("Elliot", 17 ,"Golden Eagle");
        Console.WriteLine(Elliot.Poo());
        Elliot.flight();
        Elliot.crashing();
        Elliot.die(20);
        Console.WriteLine(" ");


        Console.WriteLine("Please state age of Bat");
        int Age = int.Parse(Console.ReadLine());
        Console.WriteLine("Please state name of Bat");
        String Name = Console.ReadLine();
        Console.WriteLine("Please state species of Bat");
        String Species = Console.ReadLine();
        Tortoise Jonathan = new Tortoise("Jonathan", 190, "Seychelles giant tortoise");
        Console.WriteLine(Jonathan.Poo());
        Jonathan.moveForward();
        Jonathan.moveBackwards();
        Jonathan.die(200);



    }
}