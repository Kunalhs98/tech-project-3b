﻿/*
    Author: Kunal Samtani
    Due Date: 27/09/202
    Comments: Program displays an array 1-25, no user input
*/
using System;

namespace tech_project_3b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            foreach (var item in array)
            {
                Console.WriteLine("Element value = " + item);
            }
        }
    }
}
