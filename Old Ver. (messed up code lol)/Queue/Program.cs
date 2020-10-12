using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Collections.Generic;
using System.Text;
namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int[] getRandomArray(int maxSize, int Min, int Max)
                {

                    int[] tempArray = new int[maxSize];
                    Random randNum = new Random();
                    for (int i = 0; i < maxSize; i++)
                    {
                        tempArray[i] = randNum.Next(Min, Max);
                    }
                    return tempArray;
                }


                /*
                 * Below is just a test to reflect out a range of the array so that you can see if it worked. 
                 * Over time you may want to pull this out or keep it it does not hurt.  
                 */
                void reflectArrayRange(int[] tempArray, int fromPtr, int backPtr, string message)
                {
                    Console.WriteLine(message);
                    for (int i = fromPtr; i < backPtr; i++)
                    {
                        Console.WriteLine(tempArray[i]);
                    }
                    Console.ReadLine(); // works up to here.  Stops running for testing thats all
                    var queue = new Queue(tempArray);
                }

            }
           
        }
    }
}
