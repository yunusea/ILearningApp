using ILearningApp.Application.Interfaces.Repository;
using ILearningApp.Persistence.Context;
using ILearningApp.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILearningApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceRegistration(this IServiceCollection service)
        {
            service.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("MemoryDb"));

            service.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
