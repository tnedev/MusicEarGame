using System;

namespace NotesGame
{
    class Game
    {
        static void Main(string[] args)
        {
            Graphics.PrintingNotes();
            string game = GameEngine.GameStart();
            int correctCounter = 0;
            int wrongCounter = 0;

            while (true)
            {
                Graphics.PrintingNotes();
                if (GameEngine.GamePlay(game))
                {
                    correctCounter++;
                }
                else
                {
                    wrongCounter++;
                }
                Console.SetCursorPosition(40, 19);
                Console.WriteLine("{0} correct {1} wrong", correctCounter, wrongCounter);
                System.Threading.Thread.Sleep(4000);
                Console.Clear();
                Graphics.PrintingNotes();
            }
        }
    }
}
