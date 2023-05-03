using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.Models
{
    public class Link
    {
        [Key]
        public int LinkID { get; set; }
        [Required]
        public string LinkName { get; set; }
        [Required]
        public string URL { get; set; }
    }
}
