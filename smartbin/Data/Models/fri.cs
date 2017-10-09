using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace smartbin.Data.Models
{
    public class fri
    {
        [Key]
        public string binID { get; set; }
        public double week_1_0930 { get; set; } = 0;
        public double week_1_1530 { get; set; } = 0;
        public double week_1_2130 { get; set; } = 0;
        public double week_2_0930 { get; set; } = 0;
        public double week_2_1530 { get; set; } = 0;
        public double week_2_2130 { get; set; } = 0;
        public double week_3_0930 { get; set; } = 0;
        public double week_3_1530 { get; set; } = 0;
        public double week_3_2130 { get; set; } = 0;
        public double week_4_0930 { get; set; } = 0;
        public double week_4_1530 { get; set; } = 0;
        public double week_4_2130 { get; set; } = 0;
        public double week_5_0930 { get; set; } = 0;
        public double week_5_1530 { get; set; } = 0;
        public double week_5_2130 { get; set; } = 0;
    }
}
