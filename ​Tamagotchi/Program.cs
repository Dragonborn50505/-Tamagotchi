using System;
using System.Numerics;
using Raylib_cs; //need to instal "Raylib_cs" on every procekt using "NuGetGallery"


Console.WriteLine("Guten tag, welcome to Tamagotchi");
// Console.WriteLine("You got a new Tamagotchi");
// Tamagotchi t1 = new Tamagotchi();
// Console.WriteLine("Chose a name of your Tamagotchi");
// t1.name = Console.ReadLine();
// Console.WriteLine($"{t1.name}");

List<Tamagotchi> tamagotchis = new List<Tamagotchi>();

tamagotchis.Add(new Tamagotchi());
tamagotchis.Add(new Tamagotchi());
tamagotchis.Add(new Tamagotchi());

List<string> name = new List<string>() {"Rex", "Cody", "Wolf"};
Tamagotchi t1 = tamagotchis[0];
t1.name = name[0];
// t1.name = int name = generator.Next(2)


while (t1.GetAlive() == true)
{
    // välj tama
    // T1 = tamas[2];

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
//    if (whatDo == "6")
//    {
//        int i = 0;
//        foreach (Tamagotchi t in tamagotchis)
//        {
//            Console.WriteLine(i + ":" + t.name);
//        }
//
//
//        Console.WriteLine("which Tamagotchi would u like to play with?");
//        string WhichTammy = Console.ReadLine();
//
//
//        if (WhichTammy == "1" && Tamagotchi[0] == isAlive)
//        {
//            t1 = Tamagotchi[0] ;
//
//        }
//         if (WhichTammy == "2" && Tamagotchi[1] == isAlive)
//        {
//            t1 = Tamagotchi[1];
//
//        }
//         if (WhichTammy == "3" && Tamagotchi[2] == isAlive)
//        {
//            t1 = Tamagotchi[2];
//
//        }
//
//    }
    t1.timmer();
}
Console.WriteLine($"{t1.name} died ");



Console.ReadLine();

