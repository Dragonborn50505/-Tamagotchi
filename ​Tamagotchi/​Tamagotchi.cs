
public class Tamagotchi
{
    public int hunger;
    public string name;
    private Random generator;
    private bool isAlive;
    public int bored;
    private List<string> words = new List<string>() { "Guten tag" };





    public Tamagotchi()
    {
        generator = new Random();
        
        isAlive = true;
    }

    public void boring()
    {
        Console.WriteLine($"You played with {name}");
        bored = -3;
        if (bored <= 0)
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
        hunger -= 3;
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


}













