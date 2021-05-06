using System;

using System.Collections.Generic;

namespace AssessmentTask1
{
    class Program
    {
        static List<int> rolls = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Roll die?");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");
            string Ctn = Console.ReadLine();
            int YN;
            int.TryParse(Ctn, out YN);
            while (YN == 1)
            {
                Random random = new System.Random();
                int RanNum = random.Next(1, 6);
                Console.WriteLine("Your roll is:");
                Console.WriteLine(RanNum);
                rolls.Add(RanNum);
                Console.WriteLine("Roll again?");
                Ctn = Console.ReadLine();
                int.TryParse(Ctn, out YN);
            }
            Console.WriteLine("Anything else?");
            Console.WriteLine("1.Show all rolls");
            Console.WriteLine("2.Show older rolls");
            Console.WriteLine("3.Add rolls together");
            Console.WriteLine("4.Show avarage of rolls");
            string FnlSlc = Console.ReadLine();
            int Fnl;
            int.TryParse(FnlSlc, out Fnl);                              
            if (Fnl == 1)
            {
                Console.WriteLine("Your rolls were:");
                foreach (int i in rolls)
                {
                    Console.WriteLine(i);
                }
            }
            if (Fnl == 2)
            {
                Console.WriteLine("enter amount of rolls to find");
                string FndR = Console.ReadLine();
                int Fnd;
                int.TryParse(FndR, out Fnd);
                string OldRol = rolls.GetRange( Index: 0, count: Fnd);
                Console.WriteLine("Those rolls were:");
                
            }
            if (Fnl == 3)
            {
                Console.WriteLine("Your roll total is:");
                int sum = 0;
                foreach (int i in rolls)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
            }
            if (Fnl == 4)
            {
                Console.WriteLine("Your roll average is:");
                int sum = 0;
                int avg = 0;
                foreach (int i in rolls)
                {
                    sum += i;
                    avg = sum / i;
                }
                
                Console.WriteLine(avg);
            }

        }
    }
}
