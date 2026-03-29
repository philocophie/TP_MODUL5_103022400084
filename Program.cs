using System;

class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric hi = new HaloGeneric();
        hi.SapaUser("Sofia");
    }
}