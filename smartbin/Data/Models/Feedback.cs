using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace smartbin.Data.Models
{
    public class Feedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int fid { get; set; }
        public string cemail { get; set; }
        public string feedbacktype { get; set; }
        public string feedback { get; set; }
        public string binid { get; set; }

    }
}
