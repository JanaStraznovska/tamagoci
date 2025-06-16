using System.Xml.Serialization;

namespace tamagoci;

class Program
{
    static void Main(string[] args)
    {
        Animal animal;

        string choiseFromConsole = null;

        if (File.Exists("data.xml"))
        {
            animal = LoadData();
            animal.CheckAnimal();
        }
        else
        {
            animal = CreateAnimal();
        }

        while (choiseFromConsole != "x")
        {
            animal.WriteInfo();

            if (animal.IsAlive)
            {
                Console.WriteLine("Choose activities:");
                Console.WriteLine("1 = Do nothing");
                Console.WriteLine("2 = Eat");
                Console.WriteLine("3 = Heal");
                Console.WriteLine("4 = Play");
                Console.WriteLine("5 = Shower");
                Console.WriteLine("6 = Sleep");
                Console.WriteLine("7 = Train");
                choiseFromConsole = Console.ReadLine();
                Console.Clear();

                switch (choiseFromConsole)
                {
                    case "1":
                        animal.DoNothing();
                        break;

                    case "2":
                        animal.Eat();
                        break;

                    case "3":
                        animal.Heal();
                        break;

                    case "4":
                        animal.Play();
                        break;

                    case "5":
                        animal.Shower();
                        break;

                    case "6":
                        animal.Sleep();
                        break;

                    case "7":
                        animal.Train();
                        break;

                    case "x":
                        return;
                }
            }
            else
            {
                Console.WriteLine("Do you want play again?");
                Console.WriteLine("Y = Start again");
                Console.WriteLine("X = Exit");
                
                string endProgram = Console.ReadLine();
                Console.Clear();
                switch (endProgram)
                {
                    case "Y":
                        Console.Clear();
                        animal = CreateAnimal();
                        Console.WriteLine("A new animal was born!");
                        break;
                    case "X":
                        return;
                }
            }

            SaveAnimal(animal);

        }
    }

    private static Animal LoadData()
    {
        XmlSerializer serializer1 = new XmlSerializer(typeof(Bird));
        using (StreamReader reader = new StreamReader("data.xml"))
        {
            Animal a = serializer1.Deserialize(reader) as Bird;
            return a;
        }
    }

    private static void SaveAnimal(Animal animalToBeSaved)
    {
        if (animalToBeSaved is Bird)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Bird));
            using (StreamWriter writer = new StreamWriter("data.xml"))
            {
                serializer.Serialize(writer, animalToBeSaved);
            }
        }
    }

    private static Animal CreateAnimal()
    {
        Random random = new Random();

        int whitchAnimal = random.Next(1, 4);

        switch (whitchAnimal)
        {
            case 1:
                return new Bird();
            case 2:
                return new Turtle(); 
        }
        return new Frog();

    }





}
