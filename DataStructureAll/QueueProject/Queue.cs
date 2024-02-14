namespace DataStructureAll.QueueProject
{
    public class Queue
    {
        private Node head;
        private Node tail;
        private int size;

        public Queue()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public Queue(int data)
        {
            Node newNode = new Node(data);

            head = newNode;
            tail = newNode;
            size = 1;
        }

        //Queue-a element(node) elave etmek, Queue de sadece ve sadece sona elave etmek olur, digerlerinde ki kimi ortaya basa elave etmek olmur
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (size == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
            size++;
        }

        //Queue FIFO mentiqi ile isleyir, yeni First in First Out (Ilke daxil olan ilk cixar)
        //Queue-dan element(node) silmek
        public Node Dequeue()
        {
            Node temp = head;

            if (size == 0)
            {
                return null;
            }
            if (size == 1)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.next;
                temp.next = null;
            }
            size--;
            return temp;
        }

        //Queue-nun bos olub olmadigini yoxlamaq
        public bool IsEmpty()
        {
            return size == 0;
        }

        //Queue-nun en basindaki elementi(node)-u geri qaytarir
        public int Peek()
        {
            if (size != 0)
            {
                return head.data;
            }
            else
            {
                return -1;
            }
        }

        //Queue elementlerini(node) console-a yazdirmaq
        public void PrintAll()
        {
            Node temp = head;
            Console.WriteLine("Queue: ");
            Console.WriteLine("- - - - - - - - - - - - - - - -");

            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine("- - - - - - - - - - - - - - - -");
        }

        //Queue-nun Head elementini console-a yazdirmaq
        public void PrintHead()
        {
            if (head != null)
            {
                Console.WriteLine("Head: " + head.data);
            }
        }

        public void PrintTail()
        {
            if (tail != null)
            {
                Console.WriteLine("Tail: " + tail.data);
            }
        }

        public void PrintSize()
        {
            Console.WriteLine("Size: " + size);
        }
    }
}
