using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace smartbin.Data.Models
{
    public class working
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int workID { get; set; }
        public Workforce user { get; set; }
        public BinDetail bin { get; set; }
        public DateTime time { get; set; }
    }
}
