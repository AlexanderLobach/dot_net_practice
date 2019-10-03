using System;

namespace P_06_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            sArray ();
        }

         static void sArray ()
        {
            string [] nums = new string[3];
            nums[0]="32";
            nums[1]="A";
            nums[2]= "Hello";
            for (int i = 0; i <3; i++)
            {
                Console.WriteLine(nums[i]);
            }
            nums[0] = nums[0] + 32;
            nums[2] = nums[2] + ", gyus!";
             for (int i = 0; i <3; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

    }
}
