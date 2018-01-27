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
            
            bool AlexIsUsingThis = true;
            int[] ints = new int[10];
            Random rand = new Random();
            #region ask for 10 numbers
            if (!AlexIsUsingThis)
            {
                Console.WriteLine("Give me 10 numbers");
                for (int i = 0; i < 10; i++)
                {
                    char num = Console.ReadKey().KeyChar;
                    Console.WriteLine("");
                    if (num != '1' && num != '2' && num != '3' && num != '4' && num != '5' && num != '6' && num != '7' && num != '8' && num != '9' && num != '0')
                    {
                        Console.WriteLine("I eat numbers, not letters");
                    }
                    else
                    {
                        ints[i] = int.Parse(num.ToString());
                    }
                }
            }
            #endregion
            #region Random
            if (AlexIsUsingThis)
            {
                for (int i = 0; i < 10; i++)
                {
                    ints[i] = rand.Next(1, 11);
                    
                    Console.WriteLine(ints[i]);
                }
            }
            #endregion
            #region checking for swap
            int smallestIndex = 0;
            int index = 0;
            
            for (int BiggestIndex = 0; BiggestIndex < ints.Length - 1; BiggestIndex++)
            {
                bool swap = false;

                smallestIndex = BiggestIndex;

                for (int j = BiggestIndex + 1; j < ints.Length; j++)
                {
                    if (ints[j] < ints[smallestIndex])
                    {
                        swap = true;
                        smallestIndex = j;               
                    }
                }

                if (swap)
                {
                    int temp = ints[BiggestIndex];
                    ints[BiggestIndex] = ints[smallestIndex];
                    ints[smallestIndex] = temp;
                }                
            }
            print(ints);
            #endregion
            Console.ReadKey();
        }
        public static void print(IEnumerable<int> Ints)
        {
            Console.WriteLine("");
            foreach (int number in Ints)
            {
                Console.WriteLine(number);
            }
        }


    }
}
