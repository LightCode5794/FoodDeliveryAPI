using FoodDelivery.Application.Interfaces;
using FoodDelivery.Domain.Common;
using FoodDelivery.Domain.Common.Interfaces;
using FoodDelivery.Infrastructure.Services;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

namespace FoodDelivery.Infrastructure.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddInfrastructureLayer(this IServiceCollection services)
        {
            services.AddServices();
        }

        private static void AddServices(this IServiceCollection services)
        {
            services
                .AddTransient<IMediator, Mediator>()
                .AddTransient<IDomainEventDispatcher, DomainEventDispatcher>();
        }
    }
}
