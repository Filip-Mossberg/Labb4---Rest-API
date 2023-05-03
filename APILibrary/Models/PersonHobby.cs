using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.Models
{
    public class PersonHobby
    {
        [Key]
        public int PersonHobbyID { get; set; }  
        public Person Person { get; set; }
        public int PersonID { get; set; }
        public Hobby Hobby { get; set; }
        public int HobbyID { get; set; }
        public Link Link { get; set; }
        public int LinkID { get; set; }
    }
}
