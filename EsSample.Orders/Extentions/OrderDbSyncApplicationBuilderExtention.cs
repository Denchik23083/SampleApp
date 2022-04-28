using EsSample.Orders.OrderSync;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace EsSample.Orders.Extentions
{
    public static class OrderDbSyncApplicationBuilderExtention
    {
        public static void EnableOrderStateSyncronisation(this IApplicationBuilder app)
        {
            var scopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();

            using var scope = scopeFactory.CreateScope();
            var syncronizer = scope.ServiceProvider.GetService<IOrderDbSyncronizer>();

            syncronizer.ProcessExistingEvents();
            syncronizer.SubscribeToFutureEvents();
        }
    }

}
