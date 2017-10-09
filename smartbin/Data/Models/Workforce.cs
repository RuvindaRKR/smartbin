using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace smartbin.Data.Models
{
    public class Workforce
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userID { get; set; }
        public string uName { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public string contactNo { get; set; }
        public string pWord { get; set; }
        public string areaID { get; set; }
        public byte[] image { get; set; }


    }
}
