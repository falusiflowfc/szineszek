using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szineszek
{
    class Szineszek
    {
        public string SzineszNeve { get; set; }
        public string SzineszNeme { get; set; }
        public string SzulHely { get; set; }
        public string SzulOrszag { get; set; }
        public int FilmSzam { get; set; }

        public Szineszek(string sor)
        {
            string[] adatok = sor.Split(';');
            SzineszNeve = adatok[0];
            SzineszNeme = adatok[1];
            SzulHely = adatok[2];
            SzulOrszag = adatok[3];
            FilmSzam = int.Parse(adatok[4]);
        }


        public override string ToString()
        {
            return $"Szinesz neve:{SzineszNeve}\n Szinész neme:{SzineszNeme}\n Születési helye:{SzulHely} \n Szulorszag: {SzulOrszag} \n FilmSzam: {FilmSzam}";
        }
    }
}
