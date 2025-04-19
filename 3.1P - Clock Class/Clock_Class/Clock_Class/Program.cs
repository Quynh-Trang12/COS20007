using System;
using Clock_Class;

public class MainClass() 
{ 
    public static void Main(string[] args)
    {
        Clock clock = new Clock();
        int i = 0;
        while (i < 4200)
        {
            i++;
            clock.Tick();
            Console.WriteLine(clock.getTime());
        }
    }
}

