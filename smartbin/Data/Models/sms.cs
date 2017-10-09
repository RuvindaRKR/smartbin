using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace smartbin.Data.Models
{
    public class sms
    {
        [Key]
        
        public int binid { get; set; }
        public string cemail { get; set; }
        public string message { get; set; }
       
    }
}
