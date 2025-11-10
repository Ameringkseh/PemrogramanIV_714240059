using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P4_2_714240059;

namespace P4_2_714240059
{
    // a. ABSTRACTION (Kelas Abstrak)
    public abstract class MediaAudio
    {
        // d. ENCAPSULATION (Field dan Property)

        // 'private field'
        private string _judul;
        private int _durasiDetik;

        // 'public property'
        public string Judul
        {
            get { return _judul; }
            set { _judul = value; }
        }

        public int DurasiDetik
        {
            get { return _durasiDetik; }
            set { _durasiDetik = value; }
        }

        // e. CONSTRUCTOR (Induk)
        public MediaAudio(string judul, int durasiDetik)
        {
            this._judul = judul;
            this._durasiDetik = durasiDetik;
        }

        // a. ABSTRACTION (Metode Abstrak)
        public abstract void Putar();
    }
}