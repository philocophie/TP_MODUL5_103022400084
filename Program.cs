<<<<<<< HEAD
﻿using System;

class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
=======
﻿class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
>>>>>>> generic-class
    }
}

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        HaloGeneric hi = new HaloGeneric();
        hi.SapaUser("Sofia");
=======
        DataGeneric<string> data = new DataGeneric<string>("103022400084");
        data.PrintData();
>>>>>>> generic-class
    }
}