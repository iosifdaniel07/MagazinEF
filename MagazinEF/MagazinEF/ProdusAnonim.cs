using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinEF {
    public class ProdusAnonim {
        public int _id { get; set; }
        public string _denumire { get; set; }
        public string _descriere { get; set; }
        public int _cantitate { get; set; }

       public  ProdusAnonim(int id, string denumire, string descriere, int cantitate) {
            this._id = id;
            this._denumire = denumire;
            this._descriere = descriere;
            this._cantitate = cantitate;

        }
    }
}
