
using HospitalModuleAccount.Domain.Common;
using HospitalModuleAccount.Infrastructure.Adapter.AccountUserAdapter;
using HospitalModuleAccount.Infrastructure.Port;
using Microsoft.Extensions.DependencyInjection;
using HospitalModuleAccount.Infrastructure.Adapter;
using HospitalModuleAccount.Domain.Entities.AccountUser.Port.InterfacesServices;
using HospitalModuleAccount.Infrastructure.Adapter.TokenAdapter;

namespace HospitalModuleAccount.Infrastructure.Extensions
{
    public static class AutoLoadServices
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            //services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient(typeof(IJWTtokenService), typeof(TokenAdapterJWT));
            services.AddTransient(typeof(IAccountUserAdapterFactory), typeof(AccountUserAdapterFactory));
            

            var _services = AppDomain.CurrentDomain.GetAssemblies()
                .Where(assembly =>
                {
                    return (assembly.FullName is null) || assembly.FullName.Contains("Domain", StringComparison.InvariantCulture);
                })
                  .SelectMany(s => s.GetTypes())
                  .Where(p => p.CustomAttributes.Any(x => x.AttributeType == typeof(DomainServiceAttribute)));

            var _repositories = AppDomain.CurrentDomain.GetAssemblies()
           .Where(assembly =>
           {
               return assembly.FullName is null || assembly.FullName.Contains("Infra", StringComparison.OrdinalIgnoreCase);
           })
           .SelectMany(assembly => assembly.GetTypes())
           .Where(type => type.CustomAttributes.Any(attribute => attribute.AttributeType == typeof(RepositoryAttribute)));


            foreach (var service in _services)
            {
                services.AddTransient(service);
            }

            foreach (var repository in _repositories)
            {
                Type typeInterface = repository.GetInterfaces().Single();
                services.AddTransient(typeInterface, repository);
            }

            

            return services;

        }
    }
}
