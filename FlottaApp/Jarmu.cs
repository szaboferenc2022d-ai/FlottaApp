using System;
using System.Collections.Generic;
using System.Text;

namespace FlottaApp
{
    internal class Jarmu
    {
        string Rendszam { get; set; }
        protected int alapar { get; set; }
        public int Alapar {
            get { return alapar; }
            set
            {
                if(value > 0) alapar = value;
            }
        }
        private static int osszesJarmuSzama { get; set; }
        public static int OsszesJarmuSzama { get; }

        public Jarmu(string rendszam, int alapar, int oszesjarmuszama)
        {
            Rendszam = rendszam;
            Alapar = alapar;
        }
    

        public virtual int Adokalkulacio()
        {
            
        }

        public override string ToString()
        {
            return ($"Jármű {Rendszam} | Alapár: {Alapar} Ft | Adó: {Adokalkulacio()} Ft");
        }

    }
}
