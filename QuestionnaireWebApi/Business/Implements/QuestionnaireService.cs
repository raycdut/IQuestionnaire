using QuestionnaireWebApi.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuestionnaireWebApi.Models;

namespace QuestionnaireWebApi.Business.Implements
{
    public class QuestionnaireService : IQuestionnaireService
    {
        #region Dependence Injection of context
        private readonly QuestionnaireContext questionnaireContext;
        public QuestionnaireService(QuestionnaireContext _questionnaireContext)
        {
            questionnaireContext = _questionnaireContext;
        } 
        #endregion

        public Questionnaire Create(Questionnaire questionnaire)
        {
            //questionnaire.QuestionnaireQuestions
            throw new NotImplementedException();
        }

        public void Delete(int id, Questionnaire questionnaire = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Questionnaire> Get()
        {
            return questionnaireContext.Questionnaires.AsQueryable();
        }

        public Questionnaire Update(int id, Questionnaire questionnaire)
        {
            throw new NotImplementedException();
        }
    }
}
