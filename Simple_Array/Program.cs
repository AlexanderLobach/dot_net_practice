using System;

namespace Simple_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] num = new int[6];
            num[0] = 1;
            num[1] = 2;
            num[2] = 3;
            num[3] = 4;
            num[4] = 5;
            num[5] = 6;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(num[i]);
            }

            num[3] = 12;
            Console.WriteLine(num[3]); 
        }
    }
}
