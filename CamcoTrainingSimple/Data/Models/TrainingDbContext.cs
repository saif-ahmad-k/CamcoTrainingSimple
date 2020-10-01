using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CamcoTrainingSimple.Data.Models
{
    public partial class TrainingDbContext : DbContext
    {
        public TrainingDbContext()
        {
        }

        public TrainingDbContext(DbContextOptions<TrainingDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<tAttemptedTestInfo> tAttemptedTestInfoes { get; set; }
        public virtual DbSet<tCategory> tCategories { get; set; }
        public virtual DbSet<tChapter> tChapters { get; set; }
        public virtual DbSet<tEmployee> tEmployees { get; set; }
        public virtual DbSet<tEmployeeTraining> tEmployeeTrainings { get; set; }
        public virtual DbSet<tInterviewer> tInterviewers { get; set; }
        public virtual DbSet<tMCQ> tMCQs { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<tQuestion> tQuestions { get; set; }
        public virtual DbSet<tTest> tTests { get; set; }
        public virtual DbSet<tTestResult> tTestResults { get; set; }
        public virtual DbSet<tTraining> tTrainings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-LOD216K\\SQLEXPRESS;Database=CamcoManufacturingTaskManagement;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }
    }
}
