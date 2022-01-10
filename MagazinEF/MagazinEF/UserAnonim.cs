using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinEF {
    public class UserAnonim {

        public int Id { get; set; }
        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string Username { get; set; }


        public UserAnonim(int id, string nume, string prenume, string username) { 
            Id = id;
            Nume = nume;
            Prenume = prenume;
            Username = username;
        }
    }
}
