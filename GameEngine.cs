using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace NotesGame
{
    class GameEngine
    {
        public static bool GuessTheTone()
        {
            bool correct = false ;
            Console.SetCursorPosition(40, 15);
            Console.WriteLine("This is the tone - A");
            MusicTasks.PlaySound("A", "Tone");
            Random rnd= new Random(); 
            int randomSound = rnd.Next(1,8);

            string userGuess = " "; 

            while (userGuess == " ")
            {
                Console.SetCursorPosition(40, 16);
                Console.WriteLine("Guess this tone...");
                string sound = MusicTasks.NumberToSound(randomSound, "Tone");
                Console.SetCursorPosition(40, 17);
                Console.Write("The tone was: ");
                userGuess = Console.ReadLine();

                if (userGuess == sound)
                {
                    Console.SetCursorPosition(40, 17);
                    Console.WriteLine("That was correct");
                    correct = true;
                }
                else if(userGuess == " ")
                {
                    MusicTasks.NumberToSound(randomSound, "Tone");
                }
                else
                {
                    Console.SetCursorPosition(40, 17);
                    Console.WriteLine("The correct answar was {0}", sound);
                    correct = false;
                }
            }
            return correct; 
        }
       public static bool GuessTheChord()
        {
            bool correct = false; 
            Random rnd = new Random();
            int randomSound = rnd.Next(1, 15);
            Console.SetCursorPosition(40, 15);
            Console.WriteLine("Guess this chord...");
            string sound = MusicTasks.NumberToSound(randomSound, "Chord");
            string userGuess = " ";
            while (userGuess == " ")
            {
                Console.SetCursorPosition(40, 16);
                Console.Write("The chord was: ");
                userGuess = Console.ReadLine();

                if (userGuess == sound)
                {
                    Console.SetCursorPosition(40, 17);
                    Console.WriteLine("That was correct");
                    correct = true; 
                }
                
                else if (userGuess== " ")
                {
                    MusicTasks.NumberToSound(randomSound, "Chord");
                }
                else
                {
                    Console.SetCursorPosition(40, 17);
                    Console.WriteLine("The correct answar was {0}", sound);
                    correct = false; 
                }
            }
            return correct; 
        }
        public static bool GuessTheInterval()
        {
            bool correct = false; 
            Random rnd = new Random();
            int randomSound = rnd.Next(1, 12);
            Console.SetCursorPosition(40, 15);
            Console.WriteLine("Guess this interval...");
            string sound = MusicTasks.NumberToSound(randomSound, "Interval");


            string userGuess = " ";

            while (userGuess == " ")
            {
                Console.SetCursorPosition(40, 16);
                Console.Write("The interval was: ");
                userGuess = Console.ReadLine();

                if (userGuess == sound)
                {
                    Console.SetCursorPosition(40, 17);
                    Console.WriteLine("That was correct");
                    correct = true; 
                }
                else if (userGuess == " ")
                {
                    
                    MusicTasks.NumberToSound(randomSound, "Interval");
                }
                else
                {
                    Console.SetCursorPosition(40, 17);
                    Console.WriteLine("The correct answar was {0}", sound);
                    correct = false; 
                }
            }
            return correct; 
        }

        public static string GameStart()
        {
            Console.SetCursorPosition(40, 15);
            Console.WriteLine("Dear user, please choose your game:");
            Console.SetCursorPosition(40, 16);
            Console.WriteLine("For guessing tones type: \"Tones\"");
            Console.SetCursorPosition(40, 17);
            Console.WriteLine("For guessing chords type: \"Chords\"");
            Console.SetCursorPosition(40, 18);
            Console.WriteLine("For guessing intervals type: \"Intervals\"");
            Console.WriteLine();

            string gameChoose = "none";
            
            while (gameChoose == "none")
            {
                Console.SetCursorPosition(40, 19);
                gameChoose = Console.ReadLine();
                Console.Clear();
                Graphics.PrintingNotes();
                if (gameChoose=="Tones")
                {
                    Console.SetCursorPosition(40, 15);
                    Console.WriteLine("{0} - Good Choice!", gameChoose);
                    Console.SetCursorPosition(40, 16);
                    Console.WriteLine("Listen the tone A and then guess the following tone");
                    Console.SetCursorPosition(40, 17);
                    Console.WriteLine("You could chose between: A, B, C, D, E, F and G");
                    Console.SetCursorPosition(40, 18);
                    Console.WriteLine("Enter space to repeat the sound");
                    Console.SetCursorPosition(40, 19);
                    System.Threading.Thread.Sleep(8000);
                    Console.SetCursorPosition(40, 20);
                    Console.WriteLine("Let's Start...");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine();
                }
                else if (gameChoose=="Chords")
                {
                    Console.SetCursorPosition(40, 15);
                    Console.WriteLine("{0} - Good Choice!", gameChoose);
                    Console.SetCursorPosition(40, 16);
                    Console.WriteLine("Listen the chord and try to guess it");
                    Console.SetCursorPosition(40, 17);
                    Console.WriteLine("You could chose between: A, Am, B, Bm, C, Cm, D, Dm, E, Em, F, Fm, G and Gm");
                    Console.SetCursorPosition(40, 18);
                    Console.WriteLine("Enter space to repeat the sound");
                    System.Threading.Thread.Sleep(8000);
                    Console.SetCursorPosition(40, 19);
                    Console.WriteLine("Let's Start...");
                    System.Threading.Thread.Sleep(2000);
                }
                else if (gameChoose == "Intervals")
                {
                    Console.SetCursorPosition(40, 15);
                    Console.WriteLine("{0} - Good Choice!", gameChoose);
                    Console.SetCursorPosition(40, 16);
                    Console.WriteLine("Listen the interval and try to guess it");
                    Console.SetCursorPosition(40, 17);
                    Console.WriteLine("You could chose between: 4 ,5 ,8 ,g2 ,g3 ,g6 ,g7 ,m2 ,m3 ,m6 ,m7");
                    Console.SetCursorPosition(40, 18);
                    Console.WriteLine("Enter space to repeat the sound");
                    System.Threading.Thread.Sleep(8000);
                    Console.SetCursorPosition(40, 19);
                    Console.WriteLine("Let's Start...");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Graphics.PrintingNotes();
                }
                else
                {
                    Console.SetCursorPosition(40, 15);
                    Console.WriteLine("Wrong choice, try again");
                    gameChoose = "none";
                }
            }
            return gameChoose;
        }

        public static bool GamePlay(string gameChoose)
        {
            bool correct = false; 

            if (gameChoose == "Tones")
            {
               correct = GuessTheTone();
            }
            else if(gameChoose=="Chords")
            {
                correct = GuessTheChord();
            }
            else if(gameChoose=="Intervals")
            {
                correct = GuessTheInterval();
            }
            return correct; 
        }
    }
}
