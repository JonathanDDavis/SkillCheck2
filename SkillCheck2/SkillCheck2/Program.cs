using System;

namespace SkillCheck2
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions.print("how is this");
        }
  
    }
    class Functions
    {
        public static string print(string x)
        {
            Console.WriteLine(x);

            return x;
        }

        public static string input(string x)
        {
            x = Console.ReadLine();

            return x;

        }
        public static int input(int y)
        {
            y = int.Parse(Console.ReadLine());

            return y;
        }
    }
}
