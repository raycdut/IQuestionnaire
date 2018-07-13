using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionnaireWebApi.Models
{
    public class QuestionnaireAnswer : CommonFields
    {
        [Key]
        public int QuestionnaireAnswerId { get; set; }

        public virtual Questionnaire Questionnaire { get; set; }

        public virtual Question Question { get; set; }

        public string Answer { get; set; }


    }
}
