using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructuresCourse2022.Queue
{
    public class Queue
    {
        public int MaxSize { get; set; }
        public string [] QueueArray{ get; set; }

        public int Front{ get; set; }

        public int Rear{ get; set; }

        public int NItems{ get; set; }

        public Queue(int size)
        {
            this.MaxSize = size;
            this.QueueArray = new int[MaxSize];
            Front = 0;
            Rear = -1;

        }
        public void Enqueue(int item)
        {
            Rear++;
            QueueArray[Rear] = item;
            NItems++;

        }

        public int Dequeue()
        {
            int temp = QueueArray[]
            Front ++;
            if(Front == MaxSize)
            {
                Front = 0;
            }
            NItems--;
            return temp;
        }

    }
}