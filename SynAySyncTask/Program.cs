using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynAySyncTask
{
    //class BubbleSort
    //{
    //    //sync task start
    //    public static void bubbleSort(int[] arr, int n)
    //    {
    //        int i, j, temp;
    //        bool swapped;

    //        for (i = 0; i < n - 1; i++) 
    //        {
    //            swapped = false;
    //            for(j = 0; j < n - i - 1; j++)
    //            {
    //                if (arr[j] > arr[j+1])
    //                {
    //                    // swap them if condition is true;
    //                    temp = arr[j];
    //                    arr[j] = arr[j+1];
    //                    arr[j+1] = temp;
    //                    swapped = true;

    //                }
    //            }
    //            // if swapping not exist then break

    //            if (swapped == false) 
    //            {
    //                break;
    //            }

    //         }
    //    }

    //    public static void PrinArray(int[] arr, int size)
    //    {
    //        Stopwatch sw = new Stopwatch();
    //        sw.Start();
    //        int i;
    //        for(i = 0; i < size; i++)
    //        {
    //           //  Console.Write(arr[i] + " ");
    // var length = arr[i]

    //        }
    //            Console.WriteLine(size);

    //        sw.Stop();
    //        Console.WriteLine("\nWe are done here " + sw.Elapsed.TotalSeconds);
    //      //  Console.ReadLine();
    //    }
    //}

    //// QuickSort Class start
    //class QuickSort
    //{

    //    public static int[] SortArray(int[] array, int leftIndex, int rightIndex)
    //    {
    //        var i = leftIndex;
    //        var j = rightIndex;
    //        var pivot = array[leftIndex];
    //        while (i <= j)
    //        {
    //            while (array[i] < pivot)
    //            {
    //                i++;
    //            }

    //            while (array[j] > pivot)
    //            {
    //                j--;
    //            }
    //            if (i <= j)
    //            {
    //                int temp = array[i];
    //                array[i] = array[j];
    //                array[j] = temp;
    //                i++;
    //                j--;
    //            }
    //        }

    //        if (leftIndex < j)
    //            SortArray(array, leftIndex, j);
    //        if (i < rightIndex)
    //            SortArray(array, i, rightIndex);
    //        return array;
    //    }

    //    public static void PrintQuickSortArray(int[] arr, int size)
    //    {
    //        Stopwatch sw = new Stopwatch();
    //        sw.Start();
    //        int i;
    //        for (i = 0; i < size; i++)
    //        {
    //            Console.Write(arr[i] + " ");

    // var length =  arr[i];

    //        }
    //Console.WriteLine(size);

    //        sw.Stop();
    //        Console.WriteLine("\nWe are done here " + sw.Elapsed.TotalSeconds);
    //        // Console.ReadLine();
    //    }
    //}

    //sync task end


    //aysync task start

    class BubbleSort
    {
        //sync task start
        public static async Task bubbleSort(int[] arr, int n)
        {
            int i, j, temp;
            bool swapped;

            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap them if condition is true;
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;

                    }
                }
                // if swapping not exist then break

                if (swapped == false)
                {
                    break;
                }

            }
            await Task.CompletedTask;
        }

        public static async Task PrinArray(int[] arr, int size)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int i;
            for (i = 0; i < size; i++)
            {
                var length = arr[i];
                //Console.WriteLine();
            }
            Console.Write(size);

            sw.Stop();
            Console.WriteLine("\nWe are done here " + sw.Elapsed.TotalSeconds);
            //  Console.ReadLine();

            await Task.CompletedTask;
        }
       
    }

    // QuickSort Class start
    class QuickSort
    {

        public static async Task<int[]> SortArray(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
               await SortArray(array, leftIndex, j);
            if (i < rightIndex)
                await SortArray(array, i, rightIndex);
            return array;
        }

        public static async Task PrintQuickSortArray(int[] arr, int size)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int i;
            for (i = 0; i < size; i++)
            {
                var length = arr[i];
                
            }
            Console.WriteLine(size);

            sw.Stop();
            Console.WriteLine("\nWe are done here " + sw.Elapsed.TotalSeconds);
            // Console.ReadLine();
            await Task.CompletedTask;
        }
    }

    //aysync task end
    internal class Program
    {
        static int[] GenerateRandomArray(int length, int minValue, int maxValue)
        {
            int[] randomArray = new int[length];
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                randomArray[i] = random.Next(minValue, maxValue + 1);
            }

            return randomArray;
        }
        static async Task Main(string[] args)
        {
            int[] arr = GenerateRandomArray(20000, 1, 20000); 
            int n = arr.Length;


            //sync task start

            //BubbleSort.bubbleSort(arr, n);
            //Console.WriteLine("Bubble Sorted array:");
            //BubbleSort.PrinArray(arr, n);

            //QuickSort.SortArray(arr, 0, arr.Length - 1);
            //Console.WriteLine("Quick Sorted array:");
            //QuickSort.PrintQuickSortArray(arr, n);

            //sync task end


            //aysync task start

            var bubbleSortTask = BubbleSort.bubbleSort(arr.ToArray(), n);
            var quickSortTask = QuickSort.SortArray(arr.ToArray(), 0, arr.Length - 1);

            // Use Task.WhenAny to get the first completed task
            var ListOfTasks = new List<Task> { quickSortTask, bubbleSortTask };

            while(ListOfTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(ListOfTasks);

                if (finishedTask == bubbleSortTask)
                {
                    Console.WriteLine("Bubble Sort completed.");

                    Console.WriteLine("Bubble Sorted array:");
                    await BubbleSort.PrinArray(arr, n);
                }
                else
                {
                    Console.WriteLine("Quick Sort completed.");
                    Console.WriteLine("Quick Sorted array:");
                    await QuickSort.PrintQuickSortArray(arr, n);
                }

                await finishedTask;
                ListOfTasks.Remove(finishedTask);

            }

            Console.ReadLine();
        }
    }
}
