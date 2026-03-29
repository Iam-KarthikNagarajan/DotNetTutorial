using System.Collections;

namespace Collection
{
    class Program
    {
        public static void Main(string[] args)
        {

            //#region Array
            //int[] num = new int[5];
            //int[] num1 = { 1, 2, 3, 4, 5 };
            //int[] num2 = new int[] { 1, 2, 3, 4, 5 };

            //int[] arr = new int[2];
            //arr[0] = 1;
            //arr[1] = 2;

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //} 
            //#endregion


            //#region ArrayList
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add(4);
            //arrayList.Add("Karthik");

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //arrayList.Remove(2);
            //arrayList.RemoveAt(2);

            //Console.WriteLine("--------------------------------");

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //} 
            //#endregion

            //#region List
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //list.Remove(2);
            //list.RemoveAt(2);

            //Console.WriteLine("--------------------------------");

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //} 
            //#endregion

            //#region Hashtable
            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, "Karthik");
            //hashtable.Add(2, "Mani");
            //hashtable.Add(3, "Deepak");
            //hashtable.Add("A1", "Dass");

            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine($"{item.Key} : {item.Value}");
            //}

            //hashtable.Remove(2);
            //hashtable.Remove("A1");
            //Console.WriteLine("--------------------------------");

            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine($"{item.Key} : {item.Value}");
            //} 
            //#endregion


            //#region Dictionary
            //Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //dictionary.Add(1, "Karthik");
            //dictionary.Add(2, "Mani");
            //dictionary.Add(3, "Deepak");

            //for (int i = 0; i < dictionary.Count; i++)
            //{
            //    Console.WriteLine($"{dictionary.Keys.ElementAt(i)} : {dictionary.Values.ElementAt(i)}");
            //}

            //dictionary.Remove(2);
            //Console.WriteLine("--------------------------------");
            //for (int i = 0; i < dictionary.Count; i++)
            //{
            //    Console.WriteLine($"{dictionary.Keys.ElementAt(i)} : {dictionary.Values.ElementAt(i)}");
            //} 
            //#endregion



            //#region Stack
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //Console.WriteLine(stack.Count);
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());
            //#endregion


            #region Queue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek()); 
            #endregion



        }

    }
}
