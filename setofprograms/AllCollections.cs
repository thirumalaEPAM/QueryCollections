using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryCollection
{
    public class AllCollections
    {
        // use Array List to store different types of data
        public AllCollections() { }
        public void ArrayListExample()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(3.14);
            arrayList.Add(true);

            Console.WriteLine("ArrayList contents:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }


        // use Hashtable to store key-value pairs
        public void HashtableExample()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Name", "Alice");
            hashtable.Add("Age", 30);
            hashtable.Add("City", "New York");
            Console.WriteLine("Hashtable contents:");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
        // use Stack to store a collection of objects in a last-in-first-out (LIFO) manner
        public void StackExample()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("Hello");
            stack.Push(3.14);
            stack.Push(true);
            Console.WriteLine("Stack contents:");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }

        // use Queue to store a collection of objects in a first-in-first-out (FIFO) manner
        public void QueueExample()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("Hello");
            queue.Enqueue(3.14);
            queue.Enqueue(true);
            Console.WriteLine("Queue contents:");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }

        // use SortedList to store key-value pairs sorted by the keys
        public void SortedListExample()
        {
            SortedList sortedList = new SortedList();
            sortedList.Add("Name", "Alice");
            sortedList.Add("Age", 30);
            sortedList.Add("City", "New York");
            Console.WriteLine("SortedList contents:");
            foreach (DictionaryEntry entry in sortedList)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
        // use BitArray to store a collection of bits (boolean values)
        public void BitArrayExample()
        {
            BitArray bitArray = new BitArray(8);
            bitArray.Set(0, true);
            bitArray.Set(1, false);
            bitArray.Set(2, true);
            bitArray.Set(3, false);
            bitArray.Set(4, true);
            bitArray.Set(5, false);
            bitArray.Set(6, true);
            bitArray.Set(7, false);
            Console.WriteLine("BitArray contents:");
            for (int i = 0; i < bitArray.Length; i++)
            {
                Console.WriteLine($"Bit {i}: {bitArray.Get(i)}");
            }

        }
        // use List to store a collection of objects of the same type
        public void ListExample()
        {
            List<string> list = new List<string>();
            list.Add("Hello");
            list.Add("World");
            list.Add("C#");
            Console.WriteLine("List contents:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        // use Dictionary to store key-value pairs of the same type
        public void DictionaryExample()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("Alice", 30);
            dictionary.Add("Bob", 25);
            dictionary.Add("Charlie", 35);
            Console.WriteLine("Dictionary contents:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        //use HashSet to store a collection of unique objects
        public void HashSetExample()
        {
            HashSet<string> hashSet = new HashSet<string>();
            hashSet.Add("Hello");
            hashSet.Add("World");
            hashSet.Add("C#");
            hashSet.Add("Hello"); // Duplicate, will not be added
            Console.WriteLine("HashSet contents:");
            foreach (var item in hashSet)
            {
                Console.WriteLine(item);
            }
        }

        // use LinkedList to store a collection of objects in a doubly linked list
        public void LinkedListExample()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("Hello");
            linkedList.AddLast("World");
            linkedList.AddLast("C#");
            Console.WriteLine("LinkedList contents:");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }

        // use Queue<T> to store a collection of objects in a first-in-first-out (FIFO) manner  
        public void GenericQueueExample()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Hello");
            queue.Enqueue("World");
            queue.Enqueue("C#");
            Console.WriteLine("Generic Queue contents:");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
        // use Stack<T> to store a collection of objects in a last-in-first-out (LIFO) manner
        public void GenericStackExample()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Hello");
            stack.Push("World");
            stack.Push("C#");
            Console.WriteLine("Generic Stack contents:");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
        // use SortedDictionary to store key-value pairs sorted by the keys
        public void SortedDictionaryExample()
        {
            SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>();
            sortedDictionary.Add("Alice", 30);
            sortedDictionary.Add("Bob", 25);
            sortedDictionary.Add("Charlie", 35);
            Console.WriteLine("SortedDictionary contents:");
            foreach (var kvp in sortedDictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }


        }
}
