using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_13_Task1
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            {
            var song = new Song
            {
                Title = "Berezi",
                Minutes = 12,
                Author = "Pushkin",
                AlbumYear = DateTime.Now
            };
            var anonymousSong = GetSongData(song);
            Console.WriteLine($"\nname '{anonymousSong.GetType().GetProperty("Title").GetValue(anonymousSong)}'" +
                $"\nduration '{anonymousSong.GetType().GetProperty("Minutes").GetValue(anonymousSong)} '" +
                $"\nalbum year: '{anonymousSong.GetType().GetProperty("AlbumYear").GetValue(anonymousSong)} '" +
                $"\ngettype: '{anonymousSong.GetType()} '");
        }

        static object GetSongData(Song song)
        {
            return new
            {
                Title = song.Title,
                Minutes = song.Minutes,
                Autor = song.Author,
                AlbumYear = song.AlbumYear
            };
        }
        }
    }
}
