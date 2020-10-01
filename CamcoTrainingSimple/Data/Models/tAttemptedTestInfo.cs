using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CamcoTrainingSimple.Data.Models
{
    [Table("tblAttemptedTestInfo")]
    public class tAttemptedTestInfo
    {
        [Key]
        public int Id { get; set; }
        public int? InterviewerId { get; set; }
        public int? EmployeeId { get; set; }
        public int? TestId { get; set; }
    }
}
