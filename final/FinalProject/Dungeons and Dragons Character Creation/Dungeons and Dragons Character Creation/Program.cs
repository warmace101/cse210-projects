using System;
using Dungeons_and_Dragons_Character_Creation;


Console.WriteLine("Welcome to the start of your new character for dungeons and dragons!");

Console.WriteLine("Please select a race to start with");
Console.WriteLine("Dwarf");
Console.WriteLine("Elf");
Console.WriteLine("Halfling");
Console.WriteLine("Human");
Console.WriteLine("Dragonborn");
Console.WriteLine("Gnome");
Console.WriteLine("Half-Elf");
Console.WriteLine("Half-Orc");
Console.WriteLine("Tiefling");

string cRace = Console.ReadLine();

if (cRace.ToLower().Trim() == "dwarf")
    {
    Race race = new Race();
    race.SetDwarf("Dwarf");
    
    }
if (cRace.ToLower() == "elf")
{
    Race race = new Race();
    race.SetElf("Elf");

}
if (cRace.ToLower() == "halfling")
{
    Race race = new Race();
    race.SetHalfling("Halfling");
}
if (cRace.ToLower() == "human")
{
    Race race = new Race();
    race.SetHuman("Human");
}
if (cRace.ToLower() == "dragonborn")
{
    Race race = new Race();
    race.SetDragonborn("Dragonborn");

}
if (cRace.ToLower().Trim() == "gnome")
{
    Race race = new Race();
    race.SetGnome("Gnome");
}
if (cRace.ToLower().Trim() == "half-elf")
{
    Race race = new Race();
    race.SetHalfElf("Half-Elf");

}
if (cRace.ToLower().Trim() == "half-orc")
{
    Race race = new Race();
    race.SetHalfOrc("Half-Orc");
}

if (cRace.ToLower().Trim() =="tiefling" )

{
    Race race = new Race();
    race.SetTiefling("Tiefling");
    
}
else
{
    Console.WriteLine("Your option was not avialable. Please try again");
}

Console.Clear();

Console.WriteLine($"{cRace} has been selected as the race of your character");



Console.WriteLine("Please select a class ");
Console.WriteLine("Barbarian");
Console.WriteLine("Bard");
Console.WriteLine("Cleric");


string sClass = Console.ReadLine().Trim().ToLower();
Classes chClass = new Classes();
switch (sClass)
{
    case "barbarian":
        chClass.SetBarbarian("Barbarian");
        break;
    case "bard":
        chClass.SetBard("Bard");
        break;
    case "cleric":
        chClass.SetCleric("Cleric");
        break;
    default:
        Console.WriteLine("You had an error, this is the default case");
        break;

}
/*
if (sClass.ToLower().Trim() == "barbarian") {
    Classes chClass = new Classes();
    chClass.SetBarbarian("Barbarian");
}

if (sClass.ToLower().Trim() == "bard") {
    Classes chClass = new Classes();
    chClass.SetBard("Bard"); 
}
      
if (sClass.ToLower().Trim() == "cleric") { 
        Classes chClass = new Classes();
        chClass.SetCleric("Cleric");
       }
else {
    Console.WriteLine("You have selected an invalid option.  Please choose again.");
}*/

Console.Clear();

Console.WriteLine($"{sClass} has been chosen");

Console.Clear();

Console.WriteLine("Please write down a weapon that you would like to wield");
string weapon = Console.ReadLine();
Console.WriteLine("Please write down what kind of armour you would like to protect yourself with");
string armour = Console.ReadLine();

Console.WriteLine($"The {weapon} is your choice of weapon and the {armour} is your form of protection.");

Console.Clear();

Console.WriteLine("What will your adventurer be called?");
string name = Console.ReadLine();

Console.WriteLine($"Your name is {name}");

Console.Clear();

Console.WriteLine($"Your adventurer is {name} and your class is {sClass}\r\nYour weapon of choice is {weapon} and the armour you use {armour}");



