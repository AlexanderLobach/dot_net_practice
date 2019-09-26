using System;

namespace If_time
{
    class Program
    {
        static void Main(string[] args)
        {
           TimeSpan current_time = DateTime.Now.TimeOfDay;

Console.WriteLine( current_time);

int current_hour = current_time.Hours;

if (current_hour>=9 & current_hour<12)
{
    Console.WriteLine("Good morning, guys!");
}


if (current_hour>=12 & current_hour<15)
{
    Console.WriteLine("Good day, guys!");
}


if (current_hour>=15 & current_hour<22)
{
    Console.WriteLine("Good evening, guys!");
}


if (current_hour>=22 || current_hour<9)
{
    Console.WriteLine("Good night, guys!");
}   

Console.ReadLine();


        }
    }
}

