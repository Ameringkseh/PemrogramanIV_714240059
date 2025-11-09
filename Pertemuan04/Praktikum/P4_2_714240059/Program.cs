using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P4_2_714240059;
using System.Collections.Generic;

namespace P4_2_714240059
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Aplikasi Playlist Musik Sederhana =====");

            List<MediaAudio> playlist = new List<MediaAudio>();

            playlist.Add(new Lagu("Bohemian Rhapsody", "Queen", 354));

            playlist.Add(new PodcastEpisode("The Future of AI", "TechTalk Daily", 1820));

            playlist.Add(new Lagu("As It Was", "Harry Styles", 167));

            Console.WriteLine($"\nTotal media di playlist: {playlist.Count}\n");
            Console.WriteLine("--- Mulai Memutar Playlist ---");

            // c. POLYMORPHISM (Saat Eksekusi)
            foreach (MediaAudio media in playlist)
            {

                media.Putar();
            }

            Console.WriteLine("\n\n--- Playlist Selesai ---");
            Console.WriteLine("Tekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}