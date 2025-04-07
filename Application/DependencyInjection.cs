using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection 
{
    public static IServiceCollection AddApplication(this IServiceCollection services)  
    {
        // inyección de mediatR
        services.AddMediatR(config =>{
            config.RegisterServicesFromAssemblyContaining<ApplicationAssemblyReference>();
        });
        
        services.AddValidatorsFromAssemblyContaining<ApplicationAssemblyReference>();


        return services;
    }
}