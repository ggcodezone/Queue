using System;
using System.Collections;


namespace Queue_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); //Object creates random number
            int[] array = new int[100]; //This sets the size of the array
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = random.Next(1, 100); //this for loop is used to set the range for the value of the random numbers
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]); //this for loop prints out the array so we can check the contents 
            }
            Queue numberQueue = new Queue();
            numberQueue.Enqueue(array); //adding the array into the Queue
        }

    }
}
