using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CamcoTrainingSimple.Data.Models
{
    [Table("tblQuestion")]
    public class tQuestion
    {
        [Key]
        public int Question_Id { get; set; }
        public int TestId { get; set; }
        public string QuestionDescription { get; set; }
        public DateTime Dated { get; set; }
        public byte[] Image { get; set; }
        public string CorrectOption { get; set; }
        public string QuestionNumber { get; set; }
        [NotMapped]
        public int AttemptedTestId { get; set; }
    }
}
