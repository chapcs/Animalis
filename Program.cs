internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

abstract class Animal
{
    public abstract void MakeNoise();
}

class Hippo : Animal
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

class Wolf : Canine
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

    }
}