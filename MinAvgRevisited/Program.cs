using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAvgRevisited
{
    class Program
    {
        static void Main(string[] args)
        {
            //Finding the minimum number in an array

            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 }; //this array is a list of 10 values we'll be using

            /*Finding the minimum - This takes the first slot's value in the array (being "number" here) and compares it to itself to see if it is smaller.
             * Whichever value is lower, it keeps that value, and goes to the next slot. It keeps repeating this throughout the entire array.
             Whichever of the two is smaller, it keeps that value and moves to the next slot
             By this method, whatever value that is, it will always be the smallest, as it has already passed the test from before. It will
             keep doing this until it hits its "MaxValue" - This sounds contradictory, but thats how it works. After "number" figures itself out, "currentMinimum" grabs that value to print in the CWL*/
            int currentMinimum = Int32.MaxValue; //We start high so that any element in the array will be lower
            foreach(int number in array)
            {
                if (number < currentMinimum) { currentMinimum = number; }
            }
            Console.WriteLine("Minimum: " + currentMinimum);

            //Finding the average from the same array

            int total = 0; //start at 1st slot in array
            foreach (int number in array)
            {
                total += number;//total = total + number
            }
            float average = (float)total / array.Length;//using "float" as it can be a decimal
            //average = the total sum of the values in the array / how many slots are in the array (which could be a decimal, hence "float")
            Console.WriteLine("Average: " + average);

            Console.ReadKey();

        }        
    }
}
