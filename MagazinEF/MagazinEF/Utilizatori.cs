using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagazinEF {
    public class Utilizatori {

        [Required]
        [Key]
        public int _id { get; set; }

        [Required]
        public string _name { get; set; }

        [Required]
        public string _prenume { get; set; }

        [Required]
        public string _username { get; set; }

        [Required]
        public string _password { get; set; }

        [Required]
        public string _salt { get; set; }
    }

    public class UsersDbContext : DbContext {
       public DbSet<Utilizatori> _users { get; set; }
    }
}
