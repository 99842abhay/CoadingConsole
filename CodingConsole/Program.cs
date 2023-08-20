using CodingConsole.Algo;
using CodingConsole.DS.Queue;
using CodingConsole.DS.Stack;
using CodingConsole.Practice;
using System;

namespace CodingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String Inputs and Methos Call:
            //string str = "Welcome to coding Traning";
            //ReverseStringsCode.ReverseCompleteString(str);
            //ReverseStringsCode.ReverseEachWord(str);
            #endregion

            #region Array 
            //int[] numbers = { 1, 2, 3, 4, 5, 2, 6, 7, 8, 8 };

            //List<int> duplicates = FindDuplicates.PrintDuplicates(numbers);

            //Console.WriteLine("Duplicate numbers:");
            //foreach (int num in duplicates)
            //{
            //    Console.WriteLine(num);
            //}

            //int maxnumber = FindMax.FindMaxNumber(numbers);
            //Console.WriteLine("Max NUmber = " + maxnumber);
            #endregion

            #region Algo 
            //int[] arr = { 2, 5, 3, 8, 4, 6, 9 };
            ////SelectionSortAlgo.SelectionSort(arr);
            //InsertionSortAlgo.InsertionSort(arr);
            //BubbleSortAlgo.BubbleSort1(arr);
            #endregion

            #region Practice Code call
            //string str = "geekforgeeks";
            //PracticeCode.RemoveDuplicate(str);
            #endregion

            #region DS Stack
            //Stack<int> stack = new Stack<int>(5);

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //Console.WriteLine("Stack Count: " + stack.Count());

            //Console.WriteLine("Peek: " + stack.Peek());

            //Console.WriteLine("Pop: " + stack.Pop());
            //Console.WriteLine("Pop: " + stack.Pop());

            //Console.WriteLine("Stack Is Empty: " + stack.IsEmpty());
            #endregion

            #region DS Queue
            Queue<int> queue = new Queue<int>(5);

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("Queue Count: " + queue.Count());

            Console.WriteLine("Peek: " + queue.Peek());

            Console.WriteLine("Dequeue: " + queue.Dequeue());
            Console.WriteLine("Dequeue: " + queue.Dequeue());

            Console.WriteLine("Queue Is Empty: " + queue.IsEmpty());
            #endregion
        }
    }
}
