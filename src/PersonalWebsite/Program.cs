using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PersonalWebsite
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => 
            {
                var client = new HttpClient
                {
                    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
                };
                var config = sp.GetRequiredService<IConfiguration>();
                return client;
            });

            await builder.Build().RunAsync();
        }
    }
}
