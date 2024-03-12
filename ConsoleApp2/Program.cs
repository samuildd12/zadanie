using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Reflection;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int tempCount = 1;
            int number = 0;

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    tempCount++;
                }
                else
                {
                    tempCount = 1;
                }

                if (tempCount > count)
                {
                    count = tempCount;
                    number = arr[i];
                }
                
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write("{0}, ", number);
                Thread.Sleep(1500);
            }
        }
    }
}
