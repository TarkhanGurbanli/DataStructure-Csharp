namespace DataStructureAll.StackProject
{
    public class Stack
    {
        private Node top;
        private int count;

        public Stack()
        {
            top = null;
            count = 0;
        }

        public Stack(int data)
        {
            Node newNode = new Node(data);

            top = newNode;
            count = 1;
        }

        //Stack-e element(node) elave etmek 
        public void Push(int data)
        {
            Node newNode = new Node(data);

            if(count == 0)
            {
                top = newNode;
            }
            else
            {
                newNode.next = top;
                top = newNode;
            }
            count++;
        }

        //Stack-den element(node) silmek
        public Node Pop()
        {
            Node temp = top;
            if(count == 0)
            {
                return null;
            }

            if(count == 1)
            {
                top = null;
            }
            else
            {
                top = top.next;
                temp.next = null;
            }
            count--;
            return temp;
        }

        //Stack-in bos olub olmadigini yoxlamaq
        public bool IsEmpty()
        {
            return count == 0;
        }

        //Stack-in butun elementlerini console-a yazdirmaq
        public void PrintAll()
        {
            Node temp = top;
            Console.WriteLine("Stack: ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - ");

            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - ");
        }

        //Stack-in Top elementini console-a yazdirmaq
        public void PrintTop()
        {
            if(top != null)
            {
                Console.WriteLine("Top: " + top.data);
            }
        }

        //Stack-in Count-unu console-a yazdirmaq
        public void PrintCount()
        {
            Console.WriteLine("Count: " + count);
        }
    }
}
