using System;
using System.Collections.Generic;
using System.Text;

namespace FlottaApp
{
    internal class Teherauto : Jarmu
    {
        double Teherbiras { get; set; }

        Teherauto(double teherbiras, string rendszam, int alapar, int oszesjarmuszama) : base(rendszam, alapar, oszesjarmuszama)
        {
            Teherbiras = teherbiras;
        }

        public override int Adokalkulacio()
        {
           return base.Adokalkulacio() + (int)(Teherbiras * 1000);
        }

        public override string ToString()
        {
            return $"{base.ToString()} | Teherbírás: {Teherbiras} t";
        } 
    }
}

