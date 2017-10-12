using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElevateGraphqlWorkshop.Handler;
using ElevateGraphqlWorkshop.Schema;
using GraphQlRethinkDbLibrary.Database;
using GraphQlRethinkDbLibrary.Handlers;
using GraphQL.Conventions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ElevateGraphqlWorkshop
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            });

            BaseHandler.Setup(
                app,
                env,
                new DatabaseName(Program.DatabaseName),
                new DatabaseUrl("localhost"),
                new GraphQlDefaultHandler<ElevateQuery, ElevateMutation>(),
                new ImageFileHandler());
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddCors();
        }
    }
}
