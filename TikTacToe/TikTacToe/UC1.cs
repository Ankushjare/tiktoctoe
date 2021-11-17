using System;
using System.Collections.Generic;
using System.Text;

namespace TikTacToe
{
    public class UC1
    {
        char[] array = new char[10];
        public void Board()
        {
            for (int i =1; i< array.Length; i++)
            {
                Console.WriteLine("The array of:-"+array[i]);
            }
        }
    }
}