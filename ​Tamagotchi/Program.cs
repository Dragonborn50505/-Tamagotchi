using System;
using System.Numerics;
using Raylib_cs; //need to instal "Raylib_cs" on every procekt using "NuGetGallery"
Random generator = new Random();






List<Tamagotchi> tamagotchis = new List<Tamagotchi>();

tamagotchis.Add(new Tamagotchi());
tamagotchis.Add(new Tamagotchi());
tamagotchis.Add(new Tamagotchi());










Tamagotchi t1 = tamagotchis[0];
t1.Gretings();
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
    t1.takingCareOfT();
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
        Who = Console.ReadLine();
        if (Who == tamagotchis[0].name)
        {
            t1 = tamagotchis[0];
        }
        if (Who == tamagotchis[1].name)
        {
            t1 = tamagotchis[1];
        }
        if (Who == tamagotchis[2].name)
        {
            t1 = tamagotchis[2];
        }
        
    }
        t1.timmer();
}


    if (t1.GetAlive() == false)
    {
        t1.dead();
    }



    Console.ReadLine();



