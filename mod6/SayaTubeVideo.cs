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
        }

        public void IncreasePlayCount(int value)
        {
            this.playCount = playCount;
        }

        public void PrintVideoDetails() {
            Console.WriteLine("ID: " + id + "\n" + "Judul: " + title + "\n" + "Play count: " + playCount + "\n");
        }
    }
}
