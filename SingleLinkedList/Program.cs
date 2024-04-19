namespace SingleLinkedList
{
    class Node
    {
        public int Data;
        public Node next;
    }

    class SingleList
    {
        Node start = null, last, ptr, prev, New;
        public SingleList()
        {
            New = new Node();
            New.Data = 0;
            New.next = null;
        }
        public void InsertData(int data)
        {
            New = new Node();
            New.Data = data;
            New.next = null;

            if (start == null)
            {
                start = last = New;
                start.Data = data;
                Console.WriteLine("Start node has been added");
            }
            else
            {
                last.next = New;
                last = New;
                Console.WriteLine("Node has beed added at last");
            }
        }
        public void DisplayData()
        {
            for (ptr = start; ptr != null; ptr = ptr.next)
            {
                Console.WriteLine(ptr.Data);
            }
        }

        public void DeleteData()
        {
            for (prev = ptr = start; ptr.next != null; prev = ptr, ptr = ptr.next) ;
            prev.next = null;
            prev = last;
        }
    } 
 
           internal class Program
        {
            static void Main(string[] args)
            {
                SingleList s1 = new SingleList();
                string ch = "y";
                while (ch == "y")
                {
                    Console.WriteLine("Enter Data");
                    int data = byte.Parse(Console.ReadLine());
                    s1.InsertData(data);
                    Console.WriteLine("Want to add more data");
                    ch = Console.ReadLine();
                }
            s1.DisplayData();
            string choice = "y";
            while (choice == "y")
            {
                s1.DeleteData();

                Console.WriteLine("Want to delete more");
                choice = Console.ReadLine();
            }
            s1.DisplayData();

            }
        }
    }
