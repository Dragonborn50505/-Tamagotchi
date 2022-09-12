using System;
using System.Numerics;
using Raylib_cs; //need to instal "Raylib_cs" on every procekt using "NuGetGallery"
Random generator = new Random();






List<Tamagotchi> tamagotchis = new List<Tamagotchi>();

tamagotchis.Add(new Tamagotchi());
tamagotchis.Add(new Tamagotchi());
tamagotchis.Add(new Tamagotchi());

List<string> name = new List<string>() { "Rex", "Cody", "Wolf" };

int i = generator.Next(0, 2);
tamagotchis[0].name = name[i];
name.RemoveAt(i);
tamagotchis[1].name = name[i];
name.RemoveAt(i);
tamagotchis[2].name = name[i];







Tamagotchi t1 = tamagotchis[0];

Console.WriteLine("Guten tag, welcome to Tamagotchi");
Console.WriteLine("Pick which tamagatchi to hang out with");
Console.WriteLine("Rex, Cody, Wolf");
string Who = Console.ReadLine();



 foreach (Tamagotchi t in tamagotchis)
 {
     if (t.name == Who)
     {
         t1 = t;
     }
 }


//if (Who == "Rex") {   t1 = tamagotchis[0];    }
//if (Who = "Cody")   {   t1 = tamagotchis[1];    }
//if (Who = "Wolf")   {   t1 = tamagotchis[3];    }

while (t1.GetAlive() == true)
{
    // välj tama
    // t1 = tamas[2];
    //t1.name = tamas.name

    Console.Clear();
    t1.stats();
    Console.WriteLine("Now what do you want to do?");
    Console.WriteLine($"1. Teach {t1.name} a new word");
    Console.WriteLine($"2. Play {t1.name}");
    Console.WriteLine($"3. Feed {t1.name}");
    Console.WriteLine($"4. Talk to {t1.name}");
    Console.WriteLine($"5. Do nothing");
    Console.WriteLine($"6. Visit other Tamagotchi");
    string whatDo = Console.ReadLine();

    if (whatDo == "1")
    {
        t1.learn();
    }
    if (whatDo == "2")
    {
        t1.boring();
    }
    if (whatDo == "3")
    {
        t1.eating();
    }
    if (whatDo == "4")
    {
        t1.Talk();
    }
    if (whatDo == "5")
    {
        Console.WriteLine($"You left {t1.name} allone");
    }
    if (whatDo == "6")
    {
        Console.WriteLine($"{tamagotchis[0].name}, {tamagotchis[1].name}, {tamagotchis[2].name}");
        if ()
        {
            
        }
    }
    t1.timmer();
}
Console.WriteLine($"{t1.name} died ");



Console.ReadLine();

