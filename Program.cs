using System;
using System.ComponentModel;
class Program
{
    static int TunnelLenght(int TrainLenght, int Speed, int Time)
    {
        int IzminataDyljina = Speed * Time;
        return IzminataDyljina - TrainLenght;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Въведете дължина на влака (метра)");
        int TrainLength = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Въведете скорост на влака (m/s)");
        int Speed = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Въведете време (секунди)");
        int Time = Convert.ToInt32(Console.ReadLine());
        int TL = TunnelLenght(TrainLength, Speed, Time);

        Console.Write("Lenght of the tunnel is " + TL + " metres.");
        
    }
}
