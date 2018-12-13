using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Missionary.Models
{
    [Table("MissionQuestion")]
    public class MissionQuestion
    {
        [Key]
        public int QuestionID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        [ForeignKey("Mission")]
        public virtual int? MissionID { get; set; }
        public virtual Mission Mission { get; set; }
        [ForeignKey("User")]
        public virtual int? UserID { get; set; }
        public virtual User User { get; set; }
    }
}