using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace smartbin.Data.Models
{
    public class monthlvl
    {
        [Key]
        public string areaID { get; set; }
        public DateTime month { get; set; }
        public double PA { get; set; } = 0;
        public double PL { get; set; } = 0;
        public double GL { get; set; } = 0;
        public double BD { get; set; } = 0;
    }
}
