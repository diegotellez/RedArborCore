using Microsoft.Extensions.DependencyInjection;
using RedArbor.API.DataAccess;
using RedArbor.API.DataAccess.Contracts;
using RedArbor.API.Domain;
using RedArbor.API.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedArbor.API.DI
{
    public class DependencyInjectionProfile
    {
        public static void RegisterProfile(IServiceCollection services, Models.DbSettings configuration)
        {
            services.AddTransient<ICompanyDomainService, CompanyDomainService>();
            services.AddTransient<ICompanyRepository, CompanyRepository>();
            //services.AddTransient<Demo.DataAccess.SqlServer>();
        }
    }
}
