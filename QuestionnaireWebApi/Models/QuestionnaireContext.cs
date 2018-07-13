using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionnaireWebApi.Models
{
    public class QuestionnaireContext : DbContext
    {
        public QuestionnaireContext(DbContextOptions<QuestionnaireContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestionnaireQuestions>().HasKey(c => new { c.QuestionnaireId, c.QuestionId });
        }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Questionnaire> Questionnaires { get; set; }

        public virtual DbSet<QuestionnaireQuestions> QuestionnaireQuestions { get; set; }

        public virtual DbSet<QuestionnaireAnswer> QuestionnaireAnswers { get; set; }
    }
}
