using QuestionnaireWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionnaireWebApi.Business.Interfaces
{
    public interface IQuestionnaireService
    {
        IQueryable<Questionnaire> Get();
        Questionnaire Create(Questionnaire questionnaire);
        Questionnaire Update(int id, Questionnaire questionnaire);

        void Delete(int id, Questionnaire questionnaire = null);
    }
}
