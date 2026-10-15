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
    }
}

