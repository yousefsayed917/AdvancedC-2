using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;

namespace Demo
{
    //step 0;
    public delegate int StringFuncDelegete(string s);//declaring delegete
    // New Class [Delegate]
    // Any Reference From This Delegate Can Refer To 
    // Function Or More [Pointer To Function]
    // This Function May be Static Function [Class Member Function]
    // This Function May be Non Static Function [Object Member Function]
    // But These Functions Must be with the Same Signature of The Delegate 
    // Regardless Function Name & Access Modifier

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non Genaric Collections
            //ArrayList arrayList = new ArrayList();
            //Console.WriteLine($"Count Of ArrayList => {arrayList.Count}");//number of elememt 
            //Console.WriteLine($"Capacity Of ArrayList => {arrayList.Capacity}"); //size of array
            //arrayList.Add(1);
            ////after adding first element the capacity will be 4 (defualt capacity)
            ////new array created in heap with size 4
            //Console.WriteLine($"Count Of ArrayList => {arrayList.Count}");
            //Console.WriteLine($"after adding first elemet capacity => {arrayList.Capacity}");
            //arrayList.Add(2);
            //arrayList.AddRange(new int[] {3,4});
            //Console.WriteLine($"Count Of ArrayList => {arrayList.Count}");
            //Console.WriteLine($"Capacity Of ArrayList => {arrayList.Capacity}");
            //arrayList.Add(5);
            ////creae new array at heap with size 8
            ////take old elements and adding new element to the new array
            //Console.WriteLine($"Count Of ArrayList => {arrayList.Count}");//5
            //Console.WriteLine($"Capacity Of ArrayList => {arrayList.Capacity}");//8
            //-------------------------
            //ArrayList arrayList2 = new ArrayList(5) { 1,2,3,4,5};
            //Console.WriteLine($"Count Of ArrayList => {arrayList2.Count}");
            //Console.WriteLine($"Capacity Of ArrayList => {arrayList2.Capacity}");
            //arrayList2.Add(6);
            //Console.WriteLine($"Count Of ArrayList => {arrayList2.Count}");
            //Console.WriteLine($"Capacity Of ArrayList => {arrayList2.Capacity}");
            ////there are 16 byte (unused byte)
            ////Deallocate unused byte by using TrimToSize()
            //arrayList2.TrimToSize();
            //Console.WriteLine($"Count Of ArrayList => {arrayList2.Count}");
            //Console.WriteLine($"Capacity Of ArrayList => {arrayList2.Capacity}");
            ////create a new array at heap with size =  number of element 
            //// take the old elements + new elements in new array
            ////old array will be unreachable array
            //arrayList2.Add(7); //Boxing 
            //arrayList2.Add(8);
            //arrayList2.Add("yousef");
            ////arraylist => hetrohenous list
            ////compiler can not enforce type sefty at compilation time 
            //foreach (var item in arrayList2)
            //{
            //    Console.Write(item);
            //}

            #endregion
            #region Genaric Collections
            //List = Genaric ArrayList
            //List<int> number = new List<int>();
            //Console.WriteLine($"Count Of List {number.Count}");
            //Console.WriteLine($"Capacity Of List {number.Capacity}");
            //number.Add(1);
            ////create new list at heap size = up on adding first element to the list
            ////increased to defualt capacity =4
            //Console.WriteLine($"Count Of List {number.Count}");//1
            //Console.WriteLine($"Capacity Of List {number.Capacity}");//4
            //number.AddRange(new int[] {2,3,4});
            //Console.WriteLine($"Count Of List {number.Count}");//4
            //Console.WriteLine($"Capacity Of List {number.Capacity}");//4
            //number.Add(5);
            //Console.WriteLine($"Count Of List {number.Count}");//5
            //Console.WriteLine($"Capacity Of List {number.Capacity}");//8
            //number.TrimExcess();
            ////create new array size = count of elements 
            ////new array size =5
            ////old array unreachable
            //Console.WriteLine($"Count Of List {number.Count}");//5
            //Console.WriteLine($"Capacity Of List {number.Capacity}");//5
            //number[0] = 12;//using indexer as setter
            ////number[8] = 12;//invalid can not using indexer for adding
            //foreach (var item in number)
            //{
            //    Console.WriteLine(item);
            //}
            //number.Add("yousef");//invalid because list<int> is genaric
            #endregion
            #region List Method
            //List<int> list = new List<int>();
            //list.Add(1);//add one element
            //list.AddRange(new int[] {2,3});//add range of elements
            //list.Insert(3,4);//add element into specific index
            //list.InsertRange(4,new int[] {5,6});
            //list.Clear(); //remove all elements
            // Console.WriteLine( list.BinarySearch(5));//return index or -1 if the element is not found 
            // Console.WriteLine( list.Contains(5)); //return boolean 
            // Console.WriteLine( list.EnsureCapacity(10)); //increasing the capacity
            // Console.WriteLine( list.IndexOf(10)); //return index
            // Console.WriteLine( list.LastIndexOf(10)); //get the last index of repeted value
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region LinkedList
            //LinkedList<int> linkedlist = new LinkedList<int>();
            //linkedlist.AddFirst(1);
            //linkedlist.AddLast(3);
            //linkedlist.AddAfter(linkedlist.Find(1), 2);
            //linkedlist.AddBefore(linkedlist.Find(3), 4);
            //foreach (var item in linkedlist)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Stack
            //lifo
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //Console.WriteLine(stack.Peek());//return top element without removing it
            //Console.WriteLine(stack.Pop());//return element in the to then removing it
            #endregion
            #region Queue
            //fifo
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //Console.WriteLine(queue.Peek());//return element at begining without removing it
            //Console.WriteLine(queue.Dequeue());//return element at begining then removing it
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Dictionary
            //the key must be unique
            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(1, "yousef");
            //dic.Add(2, "Mohamed");
            //dic.Add(3, "Ahmed");
            //dic.Add(3, "Ali");//invalid
            //dic.TryAdd(5, "mona");
            //if (!dic.ContainsKey(5))
            //    dic.Add(5, "ali");
            //else
            //    dic[5] = "lala"; //update

            //foreach (KeyValuePair<int,string> item in dic)
            //{
            //    Console.WriteLine(item);

            //}
            #endregion
            #region HashSet
            //Element must be unique
            //y HashSet<int> set = new HashSet<int>();
            //set.Add(1);
            //set.Add(2);
            //set.Add(3);
            ////set.Add(1);
            //foreach (var item in set)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region intro About Delegete
            //delegete is a c# language feature
            //has 2 usage
            //1- pointer to function
            //2- event Drivin programing
            //int x = StringFunctions.GetCountOfUpperchars;invalid 

            //step 1  declare reference from delegete
            //StringFuncDelegete stringFuncDelegete;
            //step 2 Initialize Reference From Delegate[Pointer To Function]
            //stringFuncDelegete=new StringFuncDelegete(StringFunctions.GetCountOfUpperchars);
            //stringFuncDelegete = StringFunctions.GetCountOfUpperchars; //Syntax suger
            //stringFuncDelegete += StringFunctions.GetCountOfLowerchars;
            //step 3  Use Delegate Reference [Call Method] Using Invoke
            //int result = stringFuncDelegete.Invoke("YOusEF");
            //Console.WriteLine(result);
            #endregion
        }
    }
}
