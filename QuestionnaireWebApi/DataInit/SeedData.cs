using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuestionnaireWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionnaireWebApi.DataInit
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<QuestionnaireContext>();
                context.Database.Migrate();

                InitizeData(context);
            }
        }

        private static void InitizeData(QuestionnaireContext context)
        {
            //throw new NotImplementedException();
        }
    }
}
