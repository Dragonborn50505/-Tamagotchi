
public class Tamagotchi
{
    public int hunger;
    public string name;
    private Random generator;
    private bool isAlive;

    public int bored;

  

    public Tamagotchi ()
    {
        generator = new Random();
        isAlive = true;
    }

    public void playing()
    {
        bored =-2;
        if (bored <= 0)
        {
            bored = 0;
        }
    }



    public void eating()
    {
        hunger =-3;
        if (hunger <= 0)
        {
            hunger = 0;
        } 
    }

    
    public bool GetAlive()
    {
        return  isAlive;
    }

    public void timmer()
    {
        hunger++;
        bored++;

            if (hunger == 10 !& bored == 0)
            {
                isAlive = false;
            }
    }




    public void stats()
    {
        Console.WriteLine($"{name} ------------- {hunger} ------------- {bored}");
    }


}