using System;

namespace TikTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateBoard Obj = new CreateBoard();
            Obj.Board();
            ChooseLetter Obj2 = new ChooseLetter();
            Obj2.choose();
        }
    }
}
