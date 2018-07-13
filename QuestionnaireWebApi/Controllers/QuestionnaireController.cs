using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;

namespace QuestionnaireWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Questionnaire")]
    public class QuestionnaireController : ODataController
    {

    }
}