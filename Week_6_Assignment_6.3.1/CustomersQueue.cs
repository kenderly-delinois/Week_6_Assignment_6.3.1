using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6_Assignment_6._3._1
{
    class Caller
    {
        public string LName;
        public string FName;
        public int TicketNum;

        public Caller(string lName, string fName, int ticketNum)
        {
            LName = lName;
            FName = fName;
            TicketNum = ticketNum;
        }
        public override string ToString()
        {
            return ($"{FName} {LName} (Ticket: {TicketNum})");
        }
    }
    internal class CustomersQueue
    {
        public Caller Caller;
        public CustomersQueue next;

        public CustomersQueue(Caller Caller, CustomersQueue next)
        {
            this.Caller = Caller;
            this.next = next;
        }
    }

    class CallerQueue
    {
        CustomersQueue front;
        CustomersQueue rear;
        int size;

        public bool IsEmpty()
        {
            return this.size == 0;
        }

        public void Enqueue(Caller Caller)
        {
            CustomersQueue queue = new CustomersQueue(Caller , null);
            if(IsEmpty())
            {
                front = queue;
            }
            else
            {
                rear.next = queue;
            }
            rear = queue;
            size++;
        }
        public void Dequeue()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Caller Caller = front.Caller;
            front = front.next;
            size--;
            if(IsEmpty())
            {
                rear = null;
            }
            return;
        }

        public void Display()
        {
            CustomersQueue temp = front;
            if(!IsEmpty())
            {
                while(temp != null)
                {
                    Console.WriteLine(temp.Caller + " ");
                    temp = temp.next;
                }
            }
            else
            {
                Console.WriteLine("Q is empty");
            }
        }
    }
}
