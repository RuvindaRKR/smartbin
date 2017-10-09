using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace smartbin.Data.Models
{
    public class BinDetail
    {
        [Key]
        public string binID { get; set; }
        public string areaName { get; set; }
        public string areaID { get; set; }
        public double filedLevel { get; set; } = 0;
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string Status { get; set; }
        public double H00 { get; set; } = 0;
        public double H01 { get; set; } = 0;
        public double H02 { get; set; } = 0;
        public double H03 { get; set; } = 0;
        public double H04 { get; set; } = 0;
        public double H05 { get; set; } = 0;
        public double H06 { get; set; } = 0;

        public double H07 { get; set; } = 0;
        public double H08 { get; set; } = 0;
        public double H09 { get; set; } = 0;
        public double H10 { get; set; } = 0;

        public double H11 { get; set; } = 0;
        public double H12 { get; set; } = 0;
        public double H13 { get; set; } = 0;
        public double H14 { get; set; } = 0;
        public double H15 { get; set; } = 0;
        public double H16 { get; set; } = 0;
        public double H17 { get; set; } = 0;
        public double H18 { get; set; } = 0;
        public double H19 { get; set; } = 0;
        public double H20 { get; set; } = 0;
        public double H21 { get; set; } = 0;
        public double H22 { get; set; } = 0;
        public double H23 { get; set; } = 0;
    }
}
