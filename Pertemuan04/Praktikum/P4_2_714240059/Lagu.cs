using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P4_2_714240059;

namespace P4_2_714240059
{
    // b. INHERITANCE (Pewarisan)
    public class Lagu : MediaAudio
    {
        public string Artis { get; set; }

        // e. CONSTRUCTOR (Turunan)
        public Lagu(string judul, string artis, int durasiDetik)
            : base(judul, durasiDetik)
        {
            this.Artis = artis;
        }

        // c. POLYMORPHISM (Banyak Bentuk)
        public override void Putar()
        {
            Console.WriteLine($"\nMemutar Lagu:");
            Console.WriteLine($"  Judul    : {Judul}");
            Console.WriteLine($"  Artis    : {Artis}");
            Console.WriteLine($"  Durasi   : {DurasiDetik} detik");
        }
    }
}