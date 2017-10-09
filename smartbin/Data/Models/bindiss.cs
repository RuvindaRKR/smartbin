using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace smartbin.Data.Models
{
    public class bindiss
    {
        [Key]
        public string areaID { get; set; }
        public double population { get; set; }
        public int totalbins { get; set; }
    }
}
