using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.Models
{
    internal class Link
    {
        [Key]
        public int LinkID { get; set; }
        [Required]
        public string Url { get; set; }
        public string Description { get; set; }
    }
}
