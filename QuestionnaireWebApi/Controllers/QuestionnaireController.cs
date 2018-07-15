using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;
using QuestionnaireWebApi.Business.Interfaces;
using QuestionnaireWebApi.Models;
using QuestionnaireWebApi.Models.ViewModels;

namespace QuestionnaireWebApi.Controllers
{
    [Produces("application/json")]
    //[Route("api/Questionnaire")]
    public class QuestionnaireController : ODataController
    {
        private readonly IQuestionnaireService questionnaireService;
        public QuestionnaireController(IQuestionnaireService _questionnaireService)
        {
            questionnaireService = _questionnaireService;
        }

        [EnableQuery]
        public ActionResult Get()
        {
            return Ok(questionnaireService.Get());
        }
        [HttpPost]
        public ActionResult Post([FromBody]QuestionnaireVM questionnaire)
        {
            return Ok(questionnaireService.Create(questionnaire.Questionnaire));
        }
    }
}