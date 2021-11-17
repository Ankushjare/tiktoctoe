using System;
using System.Collections.Generic;
using System.Text;

namespace TikTacToe
{
    public class UC1_CreatBoard
    {
        char[] array = new char[10];
        public void Board()
        {
            for (int i =1; i< array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}