using System;
using System.Numerics;
using Raylib_cs; //need to instal "Raylib_cs" on every procekt using "NuGetGallery"

Console.WriteLine("Guten tag, welcome to Tamagotchi");
Tamagotchi T1 = new Tamagotchi();
Console.WriteLine("Chose a name of your Tamagotchi");
T1.name = Console.ReadLine();
Console.WriteLine($"{T1.name}");

while (T1.GetAlive() == true)
{
    Console.Clear();
    T1.stats();
    Console.WriteLine("Now what do you want to do?");
    Console.WriteLine($"1. Teach {T1.name} a new word");
    Console.WriteLine($"2. Talk to {T1.name}");
    Console.WriteLine($"3. Feed {T1.name}");
    Console.WriteLine($"4. Do nothing");
    string whatDo = Console.ReadLine();

    if (whatDo == "1")
    {

    }




}




Console.ReadLine();

