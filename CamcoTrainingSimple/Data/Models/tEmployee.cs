using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CamcoTrainingSimple.Data.Models
{
    [Table("tblEmployee")]
    public class tEmployee
    {
        [Key]
        public int Employee_Id { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
    }
}
