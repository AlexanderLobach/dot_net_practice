using System;

namespace P_13_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Какой хороший день";
            string textCut = CutEllipsis(text);
            Console.WriteLine(textCut);
        }
            static string CutEllipsis(string text)
            {
                if (text.Length > 5)
                {
                    text = text.Substring(0, 5) + "...";
                }
                return text;
            }    
    }
}
