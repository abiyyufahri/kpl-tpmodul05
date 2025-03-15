using System;

class HaloGeneric
{
    public static void SapaUser<T>(T X)
    {
        Console.WriteLine("Halo user " + X);
    }
}

class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void printData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric.SapaUser("Abiyyu");

        DataGeneric<string> dataGeneric = new DataGeneric<string>("103022300121");
        dataGeneric.printData();
    }
}
