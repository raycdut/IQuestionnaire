using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionnaireWebApi.Models.ViewModels
{
    public class QuestionnaireVM
    {
        public Questionnaire Questionnaire { get; set; }
        public List<QuestionnaireAnswer> Answers { get; set; }

        public List<Question> Questions { get; set; }
    }
}
