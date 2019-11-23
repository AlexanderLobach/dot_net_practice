using System;

namespace P_06_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            maxArray();
        }
        
        static void maxArray()
        {
        int [] nums = new int [13];
        Random rand = new Random();
        for (int x = 0; x < nums.Length; x++)
        {
         nums[x] = rand.Next(20);
          Console.WriteLine(nums[x]);
        }
        int max = int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
        if (nums[i] > max)
        {
        // найден больший элемент
        max = nums[i];
        }
    }
        Console.WriteLine("max(i)={0}", max);
}
    }
}
