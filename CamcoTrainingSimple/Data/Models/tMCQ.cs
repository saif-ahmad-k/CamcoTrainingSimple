using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CamcoTrainingSimple.Data.Models
{
    [Table("tblMCQ")]
    public class tMCQ
    {
        [Key]
        public int MCQ_Id { get; set; }
        public string MCQDescription { get; set; }
        public int QuestionId { get; set; }
        public string Code { get; set; }
        public byte[] MCQImage { get; set; }
    }
}
