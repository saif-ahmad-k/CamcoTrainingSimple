using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CamcoTrainingSimple.Data.Models
{
    [Table("tblEmployeeTraining")]
    public class tEmployeeTraining
    {
        [Key]
        public int EmployeeTraining_Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? CreateDate { get; set; }
        public byte[] AttachementFile { get; set; }
        public string Description { get; set; }
    }
}
