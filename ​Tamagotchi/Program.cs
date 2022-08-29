using System;
using System.Numerics;
using Raylib_cs; //need to instal "Raylib_cs" on every procekt using "NuGetGallery"



Raylib.InitWindow(800, 600, "hej");
Raylib.SetTargetFPS(60);


while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();


    Raylib.ClearBackground(Color.WHITE);
    
    
    ​Tamagotchi T1;

    T1 = new ​Tamagotchi();


    Console.WriteLine(T1);



    Raylib.EndDrawing();
}