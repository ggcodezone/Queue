using System;
using System.Collections;


namespace Queue_app
{ //Title: Create and Search Queue
  //Author: Gwen Kalasky
  //Synopsis: This program creates a queue of random itegers and allows you to search through it for factors of a number
  //Date: 10/7/20
    class Program
    {
        static void Main(string[] args)
        {   //CREATING QUEUE WITH RANDOM INTEGERS
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


            //LOOKING FOR SPECIFIC DATA IN QUEUE
            //this isn't the right way to do it because it's not working... I don't know how to refer
            //to the individual postions in the queue (I was thinking "i" but does not work)
            foreach (int i in numberQueue)
            { if (i > 3) //Just used this to test the if/else. If I want to do factors of three I'm reading you use % but I'm not entirely sure how
                {
                   numberQueue.Dequeue(); 
                }
                else
                {
                    Console.WriteLine(i); //I want to loop thru the queue; if element meets condition, write it out for user, elsewise dequeue without comment
                    numberQueue.Dequeue();
                }


            }
        }

    }
}
