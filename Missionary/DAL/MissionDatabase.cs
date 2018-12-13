using Missionary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Missionary.DAL
{
    public class MissionDatabase : DbContext
    {
        public MissionDatabase() : base("MissionDatabase") {}

        public DbSet<Mission> Missions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MissionQuestion> MissionQuestions { get; set; }
    }
}