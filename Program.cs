namespace AnimalExampleCSharp;

public class program
{
    


    public static void Main(string[] args)
    {

        bool done = false;
        List<Animal> zooAnimals = new List<Animal>();
        do
        {
            getAnimalInfo(zooAnimals);

            void getAnimalInfo(List<Animal> zooAnimals)
            {
                Console.WriteLine("What Animal are you treating?");

                string animalType = Console.ReadLine();
                switch (animalType)
                {

                    case "Bat":
                                             
                        CreateAnimal();
                        break;

                    case "Tiger":

                        CreateAnimal();
                        break;
                }

            }
            

        }
        while (!done);
        void CreateAnimal()
        {

           
            Console.WriteLine("Please state age of Animal");
            int BatAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Please state name of Animal");
            String BatName = Console.ReadLine();
            Console.WriteLine("Please state species of Animal");
            String BatSpecies = Console.ReadLine();
            Bat newBat = new Bat(BatName, BatAge, BatSpecies);
            Console.WriteLine(newBat.Name);
            Console.WriteLine(newBat.Age);
            Console.WriteLine(newBat.Species);
            Console.WriteLine(newBat.Poo());
            zooAnimals.Add(newBat);
            Console.WriteLine("  ");
            Console.WriteLine("Please state age of Animal");
            int TigerAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Please state name of Animal");
            String TigerName = Console.ReadLine();
            Console.WriteLine("Please state species of Animal");
            String TigerSpecies = Console.ReadLine();
            Tiger newTiger = new Tiger(TigerName, TigerAge, TigerSpecies);
            Console.WriteLine(newTiger.Name);
            Console.WriteLine(newTiger.Age);
            Console.WriteLine(newTiger.Species);
            Console.WriteLine(newTiger.Poo());
            zooAnimals.Add(newTiger);


        }
    }

    
}




            /* Console.WriteLine("Please state age of Bat");
             int batAge = int.Parse(Console.ReadLine());
             Console.WriteLine("Please state name of Bat");
             String batName = Console.ReadLine();
             Console.WriteLine("Please state species of Bat");
             String batSpecies = Console.ReadLine();
             Console.WriteLine(" ");
             Bat newBat = new Bat(batName, batAge, batSpecies);
             Console.WriteLine(newBat.Poo());
             newBat.flight();
             newBat.crashing();
             newBat.die(20);


              List<Animal> zoo = new List<Animal>();
              LinkedList<Animal> list = new LinkedList<Animal>();
              zoo.Add(batMy);

              foreach (Animal animal in zoo)
              {
                  Console.WriteLine(animal.Name);
              }*/



        



        


        


                /*Console.WriteLine("Please state age of Elephant");
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


                Console.WriteLine("Please state age of Tiger");
                int TigerAge = int.Parse(Console.ReadLine());
                Console.WriteLine("Please state name of Tiger");
                String TigerName = Console.ReadLine();
                Console.WriteLine("Please state species of Tiger");
                String TigerSpecies = Console.ReadLine();
                Tiger newTiger = new Tiger(TigerName, TigerAge, TigerSpecies);
                Console.WriteLine(newTiger.Poo());
                newTiger.swimming();
                newTiger.Diving();
                newTiger.Jumping();
                newTiger.Drowning();
                newTiger.die(20);
                Console.WriteLine(" ");


                Console.WriteLine("Please state age of Salmon");
                int SalmonAge = int.Parse(Console.ReadLine());
                Console.WriteLine("Please state name of Salmon");
                String SalmonName = Console.ReadLine();
                Console.WriteLine("Please state species of Salmon");
                String SalmonSpecies = Console.ReadLine();
                Salmon newSalmon = new Salmon(SalmonName, SalmonAge, SalmonSpecies);
                Console.WriteLine(newSalmon.Poo());
                newSalmon.swimming();
                newSalmon.Diving();
                newSalmon.Jumping();
                newSalmon.Drowning();
                newSalmon.die(1);
                Console.WriteLine(" ");


                Console.WriteLine("Please state age of Sloth");
                int SlothAge = int.Parse(Console.ReadLine());
                Console.WriteLine("Please state name of Sloth");
                String SlothName = Console.ReadLine();
                Console.WriteLine("Please state species of Sloth");
                String SlothSpecies = Console.ReadLine();
                Sloth newSloth = new Sloth(SlothName, SlothAge, SlothSpecies);
                Console.WriteLine(newSloth.Poo());
                newSloth.moveForward();
                newSloth.moveBackwards();
                newSloth.swimming();
                newSloth.Diving();
                newSloth.Jumping();
                newSloth.Drowning();
                newSloth.die(17);
                Console.WriteLine(" ");


                Console.WriteLine("Please state age of Eagle");
                int EagleAge = int.Parse(Console.ReadLine());
                Console.WriteLine("Please state name of Eagle");
                String EagleName = Console.ReadLine();
                Console.WriteLine("Please state species of Eagle");
                String EagleSpecies = Console.ReadLine();
                Eagle newEagle = new Eagle(EagleName, EagleAge, EagleSpecies);
                Console.WriteLine(newEagle.Poo());
                newEagle.flight();
                newEagle.crashing();
                newEagle.die(20);
                Console.WriteLine(" ");


                Console.WriteLine("Please state age of Tortoise");
                int TortoiseAge = int.Parse(Console.ReadLine());
                Console.WriteLine("Please state name of Tortoise");
                String TortoiseName = Console.ReadLine();
                Console.WriteLine("Please state species of Tortoise");
                String TortoiseSpecies = Console.ReadLine();
                Tortoise newTortoise = new Tortoise(TortoiseName, TortoiseAge, TortoiseSpecies);
                Console.WriteLine(newTortoise.Poo());
                newTortoise.moveForward();
                newTortoise.moveBackwards();
                newTortoise.die(200);*/



            
        
        