using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace NotesGame
{
    class MusicTasks
    {
        public static void PlaySound(string soundName, string type)
        {
            string fileName = soundName + ".wav";
            string typePath = "Tone";

            if (type == "Tone")
            {
                typePath = @"Sounds\Piano";
            }
            else if (type == "Chord")
            {
                typePath = @"Sounds\Piano\Chords";
            }
            else if (type == "Interval")
            {
                typePath = @"Sounds\Piano\Intervals";
            }

            string path = Path.Combine(Environment.CurrentDirectory, typePath, fileName);
            try
            {
                using (SoundPlayer player = new SoundPlayer(path))
                {
                    player.PlaySync();
                }
            }
            catch (FileNotFoundException)
            {
                Console.SetCursorPosition(40, 15);
                Console.WriteLine("A file was missing, plase report the problem");
            }

        }

        public static string NumberToSound(int numberInput, string type)
        {
            // This functions takes an random number input and type of sound and returns string to open the right file for playing

            string sound = "A";
            if (type == "Tone")
            {
                switch (numberInput)
                {
                    case 1:
                        sound = "A";
                        break;
                    case 2:
                        sound = "B";
                        break;
                    case 3:
                        sound = "C";
                        break;
                    case 4:
                        sound = "D";
                        break;
                    case 5:
                        sound = "E";
                        break;
                    case 6:
                        sound = "F";
                        break;
                    case 7:
                        sound = "G";
                        break;
                    default:
                        sound = "A";
                        break;
                }
            }
            else if (type == "Chord")
            {
                switch (numberInput)
                {
                    case 1:
                        sound = "A";
                        break;
                    case 2:
                        sound = "B";
                        break;
                    case 3:
                        sound = "C";
                        break;
                    case 4:
                        sound = "D";
                        break;
                    case 5:
                        sound = "E";
                        break;
                    case 6:
                        sound = "F";
                        break;
                    case 7:
                        sound = "G";
                        break;
                    case 8:
                        sound = "Am";
                        break;
                    case 9:
                        sound = "Bm";
                        break;
                    case 10:
                        sound = "Cm";
                        break;
                    case 11:
                        sound = "Dm";
                        break;
                    case 12:
                        sound = "Em";
                        break;
                    case 13:
                        sound = "Fm";
                        break;
                    case 14:
                        sound = "Gm";
                        break;
                    default:
                        sound = "A";
                        break;
                }
            }
            else if (type == "Interval")
            {
                switch (numberInput)
                {
                    case 1:
                        sound = "4";
                        break;
                    case 2:
                        sound = "5";
                        break;
                    case 3:
                        sound = "8";
                        break;
                    case 4:
                        sound = "g2";
                        break;
                    case 5:
                        sound = "g3";
                        break;
                    case 6:
                        sound = "g6";
                        break;
                    case 7:
                        sound = "g7";
                        break;
                    case 8:
                        sound = "m2";
                        break;
                    case 9:
                        sound = "m3";
                        break;
                    case 10:
                        sound = "m6";
                        break;
                    case 11:
                        sound = "m7";
                        break;
                    default:
                        sound = "4";
                        break;
                }
            }
            PlaySound(sound, type);
            return sound;
        }
    }
}
