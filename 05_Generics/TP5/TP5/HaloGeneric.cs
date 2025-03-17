using System;

public class HaloGeneric<T>
{
    private T data;

    public HaloGeneric(T data)
    {
        this.data = data;
    }

    public void SapaUser()
    {
        Console.WriteLine($"Halo, {data}!");
    }
}
