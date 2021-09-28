using System;

namespace HWProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[10];
            Random rand = new Random();
            
            // Fill array with random data.
            for (int i = 0, count = intArray.; i < count; i++)
            {
                intArray[i] = rand.Next(1, 101);
            }

            Console.WriteLine("Original array : " + toStringArray(intArray));
            
            int[] cloneArray = new int[intArray.Length];

            //Read and copy data from original array.
            for (int i = 0, count = intArray.Length; i < count; i++)
            {
                cloneArray[i] = intArray[i];
            }

            Console.WriteLine("Clone array : " + toStringArray(cloneArray));



        }

        // Creates string of the array's contents.
        static String toStringArray(int[] arr)
        {
            String outputString = "";
            for (int i = 0, count = arr.Length; i < count; i++)
            {
                outputString += arr[i] + " ";
            }

            return outputString;

        }
    }
}
