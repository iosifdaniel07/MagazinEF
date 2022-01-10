using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagazinEF {
    public class IstoricVanzari {

        [Required]
        [Key]
        public int _id { get; set; }

        [Required]
        public int _id_user { get; set; }

        [Required]
        public string _denumire { get; set; }

        [Required]
        public int _cantitate { get; set; }

    }

    public class IstoricVanzariDbContext : DbContext {
        public DbSet<IstoricVanzari> _istoricVanzari { get; set; }
    }
}
