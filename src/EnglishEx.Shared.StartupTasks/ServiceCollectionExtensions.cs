using EnglishEx.Shared.StartupTasks;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDbInitializer<T> (this IServiceCollection services) where T : DbContext
        {
            return services.AddAsyncInitializer<DbInitializer<T>>();
        }
    }
}