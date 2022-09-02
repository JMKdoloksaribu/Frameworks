using frameworks.data.Interface.Repositories;
using frameworks.service.Interface.Services;
using frameworks.service.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frameworks.service
{
    public class ServiceDependencyProfile
    {

        public static void Register(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped<IMahasiswaService, MahasiswaService>();
            services.AddScoped<IDbService, DbService>();
        }
    }
}
