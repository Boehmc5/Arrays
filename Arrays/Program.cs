//Christopher Boehm
//Arrays
//9/19/2019
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates an array for 25 values
            int[] Array = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

            //for loop that iterates through the array and writes to screen each value
            for (int i=1; i<26; i++)
            {  
                Console.WriteLine("Element value = " + Array[i]);

                //if statement that lets the user know the iteration process is complete
                if (Array[i] == 25)
                {
                    Console.WriteLine("Your array interations have ended...");
                }
            }

            Console.ReadKey(true);
        }
    }
}
