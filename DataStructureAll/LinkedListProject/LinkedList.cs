namespace DataStructureAll.LinkedListProject
{
    public class LinkedList
    {
        private Node head;
        private Node tail;
        private int length;

        public LinkedList()
        {
            head = null;
            tail = null;
            length = 0;
        }

        public LinkedList(int data)
        {
            Node newNode = new Node(data);
            head = newNode;
            tail = newNode;
            length = 1;
        }

        //LinkedList-e element(node) elave etmek
        public void AppendList(int data)
        {
            Node newNode = new Node(data);

            if (length == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
            length++;
        }

        //LinkedList-de Basa(Ilk node-a) element elave etmek
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);

            if (length == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
            length++;
        }

        //LinkedList-de mueyyen bir inex-e element(node) elave etmek
        public bool InsertNode(int index, int data)
        {
            if (index < 0 || index > length)
            {
                return false;
            }
            else
            {
                if (index == 0)
                {
                    AddFirst(data);
                    return true;
                }

                if (index == length)
                {
                    AppendList(data);
                    return true;
                }

                Node newNode = new Node(data);
                Node temp = GetNode(index - 1);
                newNode.next = temp.next;
                temp.next = newNode;
                length++;
                return true;
            }
        }

        //LinkedList-de mueyyen bir index-deki elemnti(nodu) tapmaq
        public Node GetNode(int index)
        {
            if (index >= 0 && index < length)
            {
                Node temp = head;

                for (int i = 0; i < index; i++)
                {
                    temp = temp.next;
                }
                return temp;
            }
            else
            {
                return null;
            }
        }

        //LinkedList-de mueyyen bir index-deki data-ni deyisdirmek
        public void SetNode(int index, int data)
        {
            Node temp = GetNode(index);

            if (temp != null)
            {
                temp.data = data;
            }
        }

        //LinkedList-in son elementini(node) silmek
        public Node DeleteLastNode()
        {
            Node temp = head;
            Node end = head;

            if (length == 0)
            {
                return null;
            }

            if (length == 1)
            {
                head = null;
                tail = null;
                return temp;
            }


            while (temp.next != null)
            {
                end = temp;
                temp = temp.next;
            }

            tail = end;
            tail.next = null;
            length--;
            return temp;
        }

        //LinkedList-in ilk elementini(node) silmek
        public Node DeleteFirstNode()
        {
            Node temp = head;

            if (length == 0)
            {
                return null;
            }

            if (length == 1)
            {
                head = null;
                tail = null;
                return temp;
            }

            head = head.next;
            temp.next = null;
            length--;
            return temp;
        }

        //LinkedList-de mueyyen bir index-deki elementi(node) silmek
        public Node DeleteNode(int index)
        {
            if (index >= 0 && index < length)
            {
                if (index == 0)
                {
                    DeleteFirstNode();
                }
                else if (index == length - 1)
                {
                    DeleteLastNode();
                }
                Node temp = GetNode(index - 1);
                Node delete = GetNode(index);
                temp.next = delete.next;
                delete.next = null;
                length--;
                return temp;
            }
            else
            {
                return null;
            }

        }

        //LinkedList butun elementlerini console-a yazdirmaq
        public void PrintList()
        {
            Node temp = head;
            Console.WriteLine("LinkedList: ");
            Console.WriteLine("- - - - - - - - - - - - - - - -");

            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine("- - - - - - - - - - - - - - - -");
        }

        //LinkedList-in Head ini console-a yazdirmaq
        public void PrintHead()
        {
            if (head != null)
            {
                Console.WriteLine("Head: " + head.data);
            }
        }

        //LinkedList-in Tail-ini console-a yazdirmaq
        public void PrintTail()
        {
            if (tail != null)
            {
                Console.WriteLine("Tail: " + tail.data);
            }
        }

        //LinkedList-in Lnegth(Uzunlugunu) console-a yazdirmaq
        public void PrintLength()
        {
            Console.WriteLine("Length: " + length);
        }
    }
}
