using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CamcoTrainingSimple.Data.Models
{
    [Table("tblTest")]
    public class tTest
    {
        [Key]
        public int Test_Id { get; set; }
        public string TestName { get; set; }
        public string TestCode { get; set; }

        public string TestDescription { get; set; }
    }
}
