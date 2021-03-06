﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Missionary.Models
{
    [Table("Mission")]
    public class Mission
    {
        [Key]
        public int MissionID { get; set; }
        public string MissionName { get; set; }
        public string PresidentName { get; set; }
        public string Address { get; set; }
        public string Language { get; set; }
        public string Climate { get; set; }
        public string Religion { get; set; }
        public string Flag { get; set; }
    }
}