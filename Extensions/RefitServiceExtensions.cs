using Refit;
using System.Text.Json.Serialization;
using System.Text.Json;
using RefitProject.Api.Service;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace RefitProject.Api.Extensions
{
    public static class RefitServiceExtensions
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {


            var jsonOptions = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                NullValueHandling = NullValueHandling.Include,
                Formatting = Formatting.Indented
            };

            jsonOptions.Converters.Add(new StringEnumConverter());

            var settings = new RefitSettings()
            {
                ContentSerializer = new NewtonsoftJsonContentSerializer(jsonOptions)
            };


            var url = configuration.GetValue<string>("RefitSettings:endpointUrl");
            services.AddRefitClient<IRefitService>()
            .ConfigureHttpClient((sp, c) =>
            {
                c.BaseAddress = new Uri(url);
                c.Timeout = TimeSpan.FromMinutes(2);
            });
        }

    }
}
    

