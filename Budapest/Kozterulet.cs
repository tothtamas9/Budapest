using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budapest
{
    public class Kozterulet
    {
        int iranyitoszam;
        string nev;
        string utotag;
        string ker;

        public Kozterulet(int iranyitoszam, string nev, string utotag, string ker)
        {
            this.iranyitoszam = iranyitoszam;
            this.nev = nev;
            this.utotag = utotag;
            this.ker = ker;
        }

        public int Iranyitoszam { get => iranyitoszam; }
        public string Nev { get => nev; }
        public string Utotag { get => utotag; }
        public string Ker { get => ker; }
    }
}
