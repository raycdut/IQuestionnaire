using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using QuestionnaireWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNet.OData.Extensions;
using QuestionnaireWebApi.Business.Interfaces;
using QuestionnaireWebApi.Business.Implements;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Query;
using QuestionnaireWebApi.DataInit;

namespace QuestionnaireWebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOData();
            services.AddMvc();

            services.AddDbContext<QuestionnaireContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("QuestionnaireContext")),
                ServiceLifetime.Scoped);

            services.AddScoped(typeof(IQuestionnaireService), typeof(QuestionnaireService));


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            //adding model class to oData
            var oDataBuilder = new ODataConventionModelBuilder();
            oDataBuilder.EntitySet<Questionnaire>("Questionnaire")
                .EntityType
                .Filter()
                .Count()
                .Expand()
                .OrderBy()
                .Page()
                .Select();

            app.UseMvc(routerBuilder =>
            {

                routerBuilder.EnableDependencyInjection();
                routerBuilder.MapODataServiceRoute("Questionnaire", "api", oDataBuilder.GetEdmModel());
            });


            #region Create database if not exists.

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<QuestionnaireContext>();
                context.Database.EnsureCreated();
            }
            #endregion

            SeedData.Initialize(app.ApplicationServices);
        }
    }
}
