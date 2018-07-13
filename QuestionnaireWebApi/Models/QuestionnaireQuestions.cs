using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionnaireWebApi.Models
{
    public class QuestionnaireQuestions : CommonFields
    {
        [Key, Column(Order = 0)]
        public int QuestionnaireId { get; set; }
        [Key, Column(Order = 1)]
        public int QuestionId { get; set; }

        public virtual Questionnaire Questionnaire { get; set; }

        public virtual Question Question { get; set; }

    }
}
