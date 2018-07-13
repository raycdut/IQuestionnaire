using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionnaireWebApi.Models
{
    public class QuestionnaireContext : DbContext
    {
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Questionnaire> Questionnaires { get; set; }

        public virtual DbSet<QuestionnaireQuestions> QuestionnaireQuestions { get; set; }

        public virtual DbSet<QuestionnaireAnswer> QuestionnaireAnswers { get; set; }
    }
}
