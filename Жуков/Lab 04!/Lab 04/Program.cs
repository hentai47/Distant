// See https://aka.ms/new-console-template for more information
using Lab_04;

Console.WriteLine("Hello, World!");

Dragon dragon1 = new Dragon();
Dragon dragon2 = new Dragon();


//атакует дракон 1
dragon2.KeepDm(dragon1.Attack());


//атакует дракон 2
dragon1.KeepDm(dragon2.Attack());

//первый дракон лечится
dragon1.Heal(1500);