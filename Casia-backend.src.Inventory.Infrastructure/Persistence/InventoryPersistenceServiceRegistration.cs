using Casia_backend.src.Inventory.Core.Domain.Repositories;
using Casia_backend.src.Inventory.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Infrastructure.Persistence
{
    public static class InventoryPersistenceServiceRegistration
    {
        public static IServiceCollection AddInventoryPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<ICatogoriesRepository, CategoriesRepository>();
            services.AddScoped<IProductRepository, ProductsRepository>();

            //Here later will be services registration

            return services;
        }
    }
}
