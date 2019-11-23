using System;


namespace P_06_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            boxUnbox();
        }
        static void boxUnbox()
        {
            Console.WriteLine("boxin operation a into o");
            ushort a= 50;
            object o= a;
            Console.WriteLine($"a= {a},  o= {o}");

            Console.WriteLine("unboxin operation o into c");
            int c = Convert.ToSByte(o);
            Console.WriteLine($"c= {c}");
        }
    }
}
