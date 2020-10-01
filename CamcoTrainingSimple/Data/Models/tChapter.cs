using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CamcoTrainingSimple.Data.Models
{
    [Table("tblChapter")]
    public class tChapter
    {
        [Key]
        public int Chapter_Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public byte[] Chapter_Attachment { get; set; }
        public int? CategoryId { get; set; }
    }
}
