using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod6
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title) { 
            this.title = title;
            Random randomID = new Random();
            id = randomID.Next(10000, 99999);
            playCount = 0;

            try
            {
                this.title = title;

                if (title == null)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (title.Length > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentNullException n_exc)
            {
                Console.WriteLine(n_exc.Message);
            }

            catch (ArgumentOutOfRangeException ofvexc)
            {
                Console.WriteLine(ofvexc.Message);
            }
        }

        public void IncreasePlayCount(int value)
        {
            try
            {
                checked
                {
                    playCount += value;
                    if (playCount + value > 10000000) throw new ArgumentOutOfRangeException();
                }
            }

            catch (ArgumentOutOfRangeException argex)
            {
                Console.WriteLine(argex.Message);
            }

            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void PrintVideoDetails() {
            Console.WriteLine("ID: " + id + "\n" + "Judul: " + title + "\n" + "Play count: " + playCount + "\n");
        }
    }
}
