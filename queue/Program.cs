using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Q = new Queue();

            Q.Enqueue(1);//Add elements to Queue
            Q.Enqueue(2);
            Q.Enqueue(3);

            Console.WriteLine("Elements in the Queue: ");

            foreach (int i in Q)//Display the elements of the queue
                Console.WriteLine(i);

            Console.WriteLine("First element in the queue: " + Q.Peek());//returns first element in the queue

            Console.WriteLine("Count of the elements in the queue: " + Q.Count);

            Console.WriteLine(Q.Dequeue()); //returns the first element and removes the referral to the element thereby making the second element as the first

            Console.WriteLine("Count of the elements after Dequeue: " + Q.Count);
        }
    }
}
