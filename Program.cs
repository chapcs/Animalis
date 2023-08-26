﻿internal class Program
{
    private static void Main(string[] args)
    {
        Animal[] animals =
        {
            new Hippo(),
            new Wolf(false),
            new Wolf(true),
            new Hippo(),
            new Wolf(false),
        };
        foreach (var animal in animals)
        {
            animal.MakeNoise();
            if (animal is ISwimmer swimmer)
                swimmer.Swim();
            if (animal is IPackHunter hunter)
                hunter.HuntInPack();
            Console.WriteLine();
        }
    }
}

interface ISwimmer
{
    void Swim();
}

interface IPackHunter
{
    void HuntInPack();
}

abstract class Animal
{
    public abstract void MakeNoise();
}

class Hippo : Animal, ISwimmer
{
    public override void MakeNoise()
    {
        Console.WriteLine("Grunt.");
    }
    public void Swim()
    {
        Console.WriteLine("Splash! I'm going for a swim!");
    }
}

abstract class Canine : Animal
{
    public bool BelongsToPack { get; protected set; } = false;//why is this set equal to false
}

class Wolf : Canine, IPackHunter
{
    public Wolf(bool belongsToPack)
    {
        BelongsToPack = belongsToPack;
    }

    public override void MakeNoise()
    {
        if (BelongsToPack)
            Console.WriteLine("I'm in a pack.");
        Console.WriteLine("Howwwlll!");
    }

    public void HuntInPack()
    {
        if (BelongsToPack)
            Console.WriteLine("Going hunting with my pack.");
        else
            Console.WriteLine("Not in a pack.");
    }
}