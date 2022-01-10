using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagazinEF {
   public class Admin {
       
        [Required]
        [Key]
        public int _id { get; set; }

        [Required]
        public string _username { get; set; }

        [Required]
        public string _password { get; set; }


        [Required]
        public string _salt { get; set; }
    }

    public class AdminDbContext : DbContext {
        public DbSet<Admin> _admin { get; set; }

        //user = admin
        //password = admin
    }
 
}
