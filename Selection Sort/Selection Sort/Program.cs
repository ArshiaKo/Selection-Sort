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
           //fix swapping
            List<int> ints = new List<int>();
            #region ask for 10 numbers
                Console.WriteLine("Give me 10 numbers");
                for (int i = 0; i < 10; i++)
                {
                    char num = Console.ReadKey().KeyChar;
                    Console.WriteLine("");
                    if(num != '1' && num != '2' && num != '3' && num != '4' && num != '5' && num != '6' && num != '7' && num != '8' && num != '9' && num != '0')
                    {
                        Console.WriteLine("I eat numbers, not letters");
                    }
                ints.Add(int.Parse(num.ToString()));
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
            print(ints);
            #endregion
            Console.ReadKey();
        }
        public static void print(List<int> Ints)
        {
            Console.WriteLine("");
            foreach (int number in Ints)
            {
                Console.WriteLine(number);
            }
        }


    }
}
