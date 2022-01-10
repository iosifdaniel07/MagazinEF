using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagazinEF {
    public class Produse {

        [Required]
        [Key]
        public int _id { get; set; }

        [Required]
        [MaxLength (30,ErrorMessage = "Denumire prea lunga")]
        public string _denumire { get; set; }

        [Required(ErrorMessage ="Descrierea este obligatorie")]
        [MaxLength(300, ErrorMessage = "Descriere prea lunga")]
        public string _descriere { get; set; }

       [Required]
       public DateTime _dataIntrare { get; set; }

        [Required(ErrorMessage ="Data expirarii este obligatorie")]
        public DateTime _dataExpirare { get; set; }

        [Required]
        public int _cantitate { get; set; }

    }

    public class MagazinDbContext : DbContext {
        public DbSet<Produse> _produse { get; set; }
    }
}
