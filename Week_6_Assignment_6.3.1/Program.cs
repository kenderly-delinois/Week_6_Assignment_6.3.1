using System;

namespace Week_6_Assignment_6._3._1
{
    internal class Program
    {
        //You are developing a program to manage a call queue of customers 
        //using the Queue  in C#. The program creates a queue of callers and 
        //demonstrates the functionality of enqueueing elements into the queue 
        //and iterating over the elements and dequeuing.

        //Use linked lists

        static void Main(string[] args)
        {
            List<Caller> callerlist = new List<Caller>();
            CallerQueue callerQueue = new CallerQueue();
            Caller newCaller = new Caller("Joseph", "Kenny", 1);
            Caller newCaller_2 = new Caller("Doe", "John", 2);
            Caller newCaller_3 = new Caller("Noel", "Kia", 3);
            Caller newCaller_4 = new Caller("Bush", "Kelly", 4);
            Caller newCaller_5 = new Caller("Jeffrey", "Oscar", 5);
            callerQueue.Enqueue(newCaller);
            callerQueue.Enqueue(newCaller_2);
            callerQueue.Enqueue(newCaller_3);
            callerQueue.Enqueue(newCaller_4);
            callerQueue.Enqueue(newCaller_5);
            callerQueue.Dequeue(); // DeQueue the first caller 
            callerQueue.Display();
        }
    }
}
