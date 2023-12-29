using WebApplication_測試MySQL_SqlSugarCore.ForDI;
using WebApplication_測試MySQL_SqlSugarCore.Models.Config;

namespace WebApplication_測試MySQL_SqlSugarCore.Startup
{
    public static class CommonSetup
    {
        private static List<DBConnectionSet> SetupDBConnectionSetConfig(IServiceProvider sp)
        {
            var appConfig = new List<DBConnectionSet>();
            var config = sp.GetRequiredService<IConfiguration>();
            config.GetSection("DBConfigs").Bind(appConfig);

            return appConfig;
        }

        public static void SetupCommonLibrary(this IServiceCollection services)
        {

            services.AddSingleton(SetupDBConnectionSetConfig);
           
            services.InitSqlSugar2();





            
        }
    }
}
