using System;

namespace If_time
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Enter your name:");
          string Name= Console.ReadLine();     
          Console.Clear();
          //var btn= ConsoleKey.Escape;
          ConsoleKeyInfo cki= new ConsoleKeyInfo();
          
       while (true)
       {
           
      Console.Clear();
                         
          TimeSpan current_time = DateTime.Now.TimeOfDay;
          Console.WriteLine($"current time {current_time.ToString(@"hh\:mm\:ss")}");
        

int current_hour = current_time.Hours;

if (current_hour>=9 & current_hour<12)
{
    Console.WriteLine($"Good morning, {Name}!");
}


if (current_hour>=12 & current_hour<15)
{
    Console.WriteLine($"Good day, {Name}!");
}


if (current_hour>=15 & current_hour<22)
{
    Console.WriteLine($"Good evening, {Name}!");
}


if (current_hour>=22 || current_hour<9)
{
    Console.WriteLine($"Good night, {Name}!");
}   

Console.WriteLine("\nPress ESC to exit");
System.Threading.Thread.Sleep(1000);
    

if (Console.KeyAvailable == true)

                {

                    cki = Console.ReadKey(true);

                    if (cki.Key == ConsoleKey.Escape)

                    {

                        break;

                    }

                }

            }
        }
    }
}

 
