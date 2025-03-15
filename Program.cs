using System;

class HaloGeneric
{
    public static void SapaUser<T>(T X)
    {
        Console.WriteLine("Halo user " + X);
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric.SapaUser("Abiyyu");
    }
}