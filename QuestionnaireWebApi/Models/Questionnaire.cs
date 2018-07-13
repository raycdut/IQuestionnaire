using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionnaireWebApi.Models
{
    public class Questionnaire : CommonFields
    {
        [Key]
        public int QuestionnaireId { get; set; }
        public string QuestionnaireName { get; set; }
        public string QuestionnaireDescription { get; set; }

        public virtual ICollection<QuestionnaireQuestions> QuestionnaireQuestions { get; set; }
    }
}
