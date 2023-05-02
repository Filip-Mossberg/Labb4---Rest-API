using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.Models
{
    internal class PersonHobby
    {
        [Key]
        public int PersonID { get; set; }
        public int HobbyID { get; set; }
        public int LinkID { get; set; }
    }
}
