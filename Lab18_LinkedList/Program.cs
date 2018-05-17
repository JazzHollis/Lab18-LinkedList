using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            BeautifulList names = new BeautifulList();

            names.Add("Jasmine");
            names.Add("Jessie");
            names.Add("Jessica");

            names.PrintInfo();
            names.RemoveAll("Jessie");

            names.PrintInfo();


            int[] numbers = { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 1, 10 };


            int max = 10;
           

            foreach(int number in numbers) //each element that is less than the declared max number 
                                           //in the array is compared to max
            {
                if (number > max)
                {
                    max = number;
                }
            }

            int[] freq = new int[max + 1];// Defines the 11 spaces needed for the the values

            for (int i = 0; i < numbers.Length; i++)// Reads the length of the array
            {
                
                    freq[numbers[i]]++;//  The number is identified then cycled through 
                                       //  to increment the count of element occurrences.
                
            }

            for (int i = 0; i < freq.Length; i++)// Idetifies the number of times 
                                                //a specific element occurs in the array.
            {
                Console.WriteLine($"[{i}] occurs {freq[i]} time(s) in the array.");
            }
            
            


        }
    }
}
