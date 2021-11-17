using System;
using System.Collections.Generic;
using System.Text;

namespace TikTacToe
{
    class ChooseLetter
    {
        public void choose()
        {
            Console.WriteLine("P1- Choose the letter X Otherwise O ");
            string A = Console.ReadLine();
            if (A == "X")
            {
                Console.WriteLine("P1 use X");
            }
            else
            {
                Console.WriteLine("P1 use O");
            }
        }

    }
}