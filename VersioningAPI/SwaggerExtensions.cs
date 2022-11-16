using Microsoft.OpenApi.Models;

namespace VersioningAPI;

internal static class SwaggerExtensions
{
    internal static IServiceCollection AddSwaggerDocs(this IServiceCollection services)
    {
        return services.AddSwaggerGen(opts =>
        {
            var title = "My Versioned API";
            var description = "This is a Web API to demonstrate versioning";
            var termsOfService = new Uri("https://localhost:7253/terms");
            var license = new OpenApiLicense()
            {
                Name = "This is the full license information",
            };
            var contact = new OpenApiContact()
            {
                Name = "Corbyn Altman Helpdesk",
                Email = "c@c.com",
                Url = new Uri("https://www.corbynaltman.com")
            };
            
            opts.SwaggerDoc("v1", new OpenApiInfo()
            {
                Version = "v1",
                Title = $"{title} v1",
                Description = description,
                TermsOfService = termsOfService,
                License = license,
                Contact = contact
            });
            
            opts.SwaggerDoc("v2", new OpenApiInfo()
            {
                Version = "v2",
                Title = $"{title} v2",
                Description = description,
                TermsOfService = termsOfService,
                License = license,
                Contact = contact
            });
        });
    }
}
