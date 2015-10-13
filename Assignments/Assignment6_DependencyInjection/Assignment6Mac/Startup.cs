using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Framework.DependencyInjection;

namespace Assignment6
{
	public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

			/*
			* TODO: Register all dependencies here.
			*/
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
			app.UseCors(policy => policy
			   .WithOrigins("*")
			   .AllowAnyMethod()
			   .AllowAnyHeader()
			   .WithExposedHeaders(new string[] { "request-id", "stopwatch"}));

			app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
