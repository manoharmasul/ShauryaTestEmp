using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShauryaTest.Models
{
    [Table("employee")]
    public class employee
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Eid { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string Gender { get; set; }
        [DataType(DataType.Date)]
        public string DOB { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Pcode { get; set; }


        public long Mobile { get; set; }

    }
}
