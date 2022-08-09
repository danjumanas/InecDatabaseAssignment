using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace InecDatabaseAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> sortList = new SortedList<string, int>();

            string[] inecArray = { "shola", "ayo", "nas", "odun", "emma", "nas", "ayo", "mac", "john", "ayo" };



            foreach (var name in inecArray)
            {
                int noOfTimes = 0;
                if (sortList.ContainsKey(name))
                {
                    continue;
                }
                for (int i = 0; i < inecArray.Length; i++)
                {
                    if (name == inecArray[i])
                    {
                        noOfTimes++;
                    }
                }
                if (noOfTimes > 1)
                {
                    sortList.Add(name, noOfTimes);
                }
            }
            foreach (var item in sortList)
            {
                Console.WriteLine(item);

            }
        }
    }
}
