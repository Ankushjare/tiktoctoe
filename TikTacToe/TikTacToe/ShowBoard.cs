using System;
using System.Collections.Generic;
using System.Text;

namespace TikTacToe
{
    class ShowBoard
    {
        char[] array = new char[10];
        public void showBoard()
        {
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", array[1], array[2], array[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", array[4], array[5], array[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", array[7], array[8], array[9]);
        }
    }
}
