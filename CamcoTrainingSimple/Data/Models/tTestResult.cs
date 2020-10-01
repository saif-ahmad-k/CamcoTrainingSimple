using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CamcoTrainingSimple.Data.Models
{
    [Table("tblTestResult")]
    public class tTestResult
    {
        [Key]
        public int Id { get; set; }
        public int TestId { get; set; }
        public int QuestionId { get; set; }
        public string SelectedOption { get; set; }
        public int? McqId { get; set; }
        public int? AttemptedTestInfoId { get; set; }

        public string QuestionNo { get; set; }

        public string CorrectOption { get; set; }
    }
}
