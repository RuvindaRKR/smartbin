using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace smartbin.Data.Models
{
    public class SensorCheck
    {
        [Key]
        public string binID { get; set; }
        public double filedLevel_1 { get; set; } = 0;
        public double filedLevel_2 { get; set; } = 0;
        public DateTime filedTime { get; set; }
    }
}
