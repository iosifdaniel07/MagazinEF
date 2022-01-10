using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinEF {
    public class VanzariAnonime {
        public int IdUser { get; set; }
        public string Denumire { get; set; }
        public int Cantitate { get; set; }

        public VanzariAnonime(int id, string denumire, int cantitate) {
            this.IdUser = id;
            this.Denumire = denumire;
            this.Cantitate = cantitate;

        }
    }
}