using Casia_backend.src.Inventory.Core.Application.DTOs;
using Casia_backend.src.Inventory.Core.Application.Features.Categories.Commands.AddCategory;
using Casia_backend.src.Inventory.Core.Application.Features.Categories.Quries.GetAllCategories;
using Casia_backend.src.Inventory.Core.Application.Features.Categories.Quries.GetCategoryById;
using Casia_backend.src.Inventory.Core.Application.Features.Products.Commands.AddProductToStorage;
using Casia_backend.src.Inventory.Core.Application.Features.Products.Queries.GetAllProducts;
using Casia_backend.src.Inventory.Core.Application.Features.Products.Queries.GetProductsById;
using Casia_backend.src.Inventory.Core.Domain.DTOs;
using Casia_backend.src.Inventory.Core.Domain.Entities;
using Casia_backend.src.Inventory.Core.Domain.Repositories;
using Casia_backend.src.Shared.Commands;
using Casia_backend.src.Shared.Queries;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casia_backend.src.Inventory.Core.Application
{
    public static class InventoryApplicationServiceRegistration
    {
        public static IServiceCollection AddIntentoryServices(this IServiceCollection services, IConfiguration config)
        {
            //Products
            services.AddScoped<ICommandHandler<AddProductToStorageCommand, CommandResponse<Guid>>>();
            services.AddScoped<IQueryHandler<GetAllProductsQuery, QueryResponse<IReadOnlyList<Product>>>>();
            services.AddScoped<IQueryHandler<GetProductByIdQuery, QueryResponse<ProductDto>>>();

            //Categories
            services.AddScoped<ICommandHandler<AddCategoryCommand, CommandResponse<CategoryDto>>>();
            services.AddScoped<IQueryHandler<GetAllCategoriesQuery, QueryResponse<IReadOnlyList<CategoryDto>>>>();
            services.AddScoped<IQueryHandler<GetCategoryByIdQuery, QueryResponse<CategoryDto>>>();

            return services;
        }
    }
}
