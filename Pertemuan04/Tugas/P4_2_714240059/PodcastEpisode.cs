using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P4_2_714240059;

namespace P4_2_714240059
{
    // b. INHERITANCE (Pewarisan)
    public class PodcastEpisode : MediaAudio
    {
        public string NamaPodcast { get; set; }

        // e. CONSTRUCTOR (Turunan)
        public PodcastEpisode(string judulEpisode, string namaPodcast, int durasiDetik)
            : base(judulEpisode, durasiDetik)
        {
            this.NamaPodcast = namaPodcast;
        }

        // c. POLYMORPHISM
        public override void Putar()
        {
            Console.WriteLine($"\nMemutar Podcast:");
            Console.WriteLine($"  Podcast  : {NamaPodcast}");
            Console.WriteLine($"  Episode  : {Judul}");
            Console.WriteLine($"  Durasi   : {DurasiDetik} detik");
        }
    }
}