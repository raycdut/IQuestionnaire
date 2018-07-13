using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionnaireWebApi.Models
{
    public class Question : CommonFields
    {
        [Key]
        public int QuestionId { get; set; }
        public string QuestionDescription { get; set; }
        public string Type { get; set; }

        public virtual ICollection<QuestionnaireQuestions> QuestionnaireQuestions { get; set; }
    }
}
