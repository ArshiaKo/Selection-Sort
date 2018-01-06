using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            Random rand = new Random();
            bool random = true;
            Console.WriteLine("Do you want to type in 10 numbers or random \ntype 10 or random");
            string choice = Console.ReadLine();
            #region ask for 10 numbers
            if (choice == "10")
            {
                random = false;
            }

            else if (choice == "random" || choice == "")
            {
                random = true;
            }

            if (random)
            {
                for (int i = 0; i < 11; i++)
                {
                    ints.Add(rand.Next(1,101));
                }
            }

            if (!random)
            {
                Console.WriteLine("Give me 10 numbers");
                for (int i = 0; i < 10; i++)
                {
                    ints.Add(int.Parse(Console.ReadLine()));
                }
                
            }
            Console.WriteLine("");
            foreach (int number in ints)
            {
                Console.WriteLine(number);
            }
            #endregion
            #region checking for swap
            int smallest = int.MaxValue;
            int index = -1;
            for (int i = 0; i < ints.Count - 1; i++)
            {
                for (int j = i; j < ints.Count; j++)
                {
                    if (ints[j] < smallest)
                    {
                        index = j;
                        smallest = ints[j];
                        ints[j] = ints[index];
                        

                    }
                }
            }
            #endregion
            Console.ReadKey();
        }
    }
}
