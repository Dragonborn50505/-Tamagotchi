using System;
using System.Numerics;
using Raylib_cs; //need to instal "Raylib_cs" on every procekt using "NuGetGallery"

Console.WriteLine("Guten tag, welcome to Tamagotchi");
Tamagotchi T1 = new Tamagotchi();
Console.WriteLine("Chose a name of your Tamagotchi");
T1.name = Console.ReadLine();
Console.WriteLine($"{T1.name}");

// List<Tamagotchi> tamas = new();
// tamas.Add(new Tamagotchi());
// tamas.Add(new Tamagotchi());
// tamas.Add(new Tamagotchi());

while (T1.GetAlive() == true)
{
    // välj tama
    // T1 = tamas[2];

    Console.Clear();
    T1.stats();
    Console.WriteLine("Now what do you want to do?");
    Console.WriteLine($"1. Teach {T1.name} a new word");
    Console.WriteLine($"2. Play {T1.name}");
    Console.WriteLine($"3. Feed {T1.name}");
    Console.WriteLine($"4. Talk to {T1.name}");
    Console.WriteLine($"5. Do nothing");
    Console.WriteLine($"6. Visit other Tamagotchi");
    string whatDo = Console.ReadLine();

    if (whatDo == "1")
    {
        T1.learn();
    }
    if (whatDo == "2")
    {
        T1.boring();
    }
    if (whatDo == "3")
    {
        T1.eating();
    }
    if (whatDo == "4")
    {
        T1.Talk();
    }
    if (whatDo == "5")
    {
        Console.WriteLine($"You left {T1.name} allone");
    }
    if (whatDo == "6")
    {
        
    }
    T1.timmer();
}
Console.WriteLine($"{T1.name} died ");



Console.ReadLine();

