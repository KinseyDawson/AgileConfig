using Microsoft.Extensions.DependencyInjection;

namespace AgileConfig.Server.Data.Freesql
{
    public static class ServiceCollectionExt
    {
        public static void AddFreeSqlDbContext(this IServiceCollection sc)
        {
            sc.AddFreeDbContext<FreeSqlContext>(options => options.UseFreeSql(FreeSQL.Instance));
            //sc.AddSingleton<IFreeSql>(FreeSQL.Instance);
            //sc.AddScoped<FreeSqlContext, FreeSqlContext>();
        }
    }
}
