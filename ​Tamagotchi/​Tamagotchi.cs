
public class Tamagotchi
{
    public int hunger;
    public string name;
    private Random generator;
    private bool isAlive;
    public int bored;
    private List<string> words = new List<string>() { "Guten tag" };

    static private List<string> names = new List<string>() { "Rex", "Cody", "Wolf" };




    public Tamagotchi()
    {
        generator = new Random();

        isAlive = true;

        int i = generator.Next(0, names.Count);
        name = names[i];
        names.RemoveAt(i);

    }

    public void boring()
    {
        Console.WriteLine($"You played with {name}");
        bored -= 3;
        if (bored < 0)
        {
            bored = 0;
        }
    }

    public void learn()
    {
        Console.WriteLine($"What word would you like to learn {name}");
        string word = Console.ReadLine();
        Console.WriteLine($" {name} now know {word}");
        words.Add(word);
    }

    public void eating()
    {
        hunger -= 4;
        if (hunger < 0)
        {
            hunger = 0;
        }
    }












    public void Talk()
    {
        int wordNum = generator.Next(words.Count);
        Console.WriteLine($"{name} says {words[wordNum]}");
        Console.ReadLine();

    }

    public bool GetAlive()
    {
        return isAlive;
    }

    public void timmer()
    {
        hunger++;
        bored++;

        if (hunger == 10 || bored == 10)
        {
            isAlive = false;
        }
    }




    public void stats()
    {
        Console.WriteLine($"Name:{name} ---- Hunger:{hunger} ---- Bored:{bored} ---- learned words:{words.Count}");
    }


    public void Gretings()
    {
        Console.WriteLine("Guten tag, welcome to Tamagotchi");
        Console.WriteLine("Pick which tamagatchi to hang out with");
        Console.WriteLine("Rex, Cody, Wolf");

    }

    public void takingCareOfT()
    {
        stats();
        Console.WriteLine("Now what do you want to do?");
        Console.WriteLine($"1. Teach {name} a new word");
        Console.WriteLine($"2. Play {name}");
        Console.WriteLine($"3. Feed {name}");
        Console.WriteLine($"4. Talk to {name}");
        Console.WriteLine($"5. Do nothing");
        Console.WriteLine($"6. Visit other Tamagotchi");
    }

   public void dead()
   {
            Console.WriteLine($"{name} died ");

   }




}













