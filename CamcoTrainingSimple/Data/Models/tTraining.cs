using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CamcoTrainingSimple.Data.Models
{
    [Table("tblTraining")]
    public class tTraining
    {
        [Key]
        public int Training_Id { get; set; }
        public string TrainingCode { get; set; }
        public string TrainingDescription { get; set; }
        public byte[] TrainingAttachement { get; set; }
        public int? CategoryId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ChapterId { get; set; }
    }
}
