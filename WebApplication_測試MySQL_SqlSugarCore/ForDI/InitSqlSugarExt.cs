using SqlSugar;
using WebApplication_測試MySQL_SqlSugarCore.Models.Config;

namespace WebApplication_測試MySQL_SqlSugarCore.ForDI
{
    /// <summary>
    /// 初始化SqlSugar
    /// </summary>
    public static class InitSqlSugarExt
    {
        /// <summary>
        /// 第一種註冊法 初始化SqlSugar builder.InitSqlSugar();
        /// </summary>
        /// <param name="builder"></param>
        public static void InitSqlSugar(this WebApplicationBuilder builder)
        {
            //builder.Services.AddSingleton(service =>
            //{
            //    Configs_DBConnection config = new Configs_DBConnection();
            //    builder.Configuration.Bind("Settings", config);

            //    return config;
            //});
            builder.Services.AddSingleton(ServiceProvider =>
            {
                var config = ServiceProvider.GetRequiredService<List<DBConnectionSet>>();
                if (config == null)
                {
                    throw new Exception("No Connection config");
                }
                List<ConnectionConfig> configs = new List<ConnectionConfig>();

                foreach (var item in config)
                {
                    configs.Add(
                        new ConnectionConfig()
                        {
                            ConfigId = item.DBBASE,
                            ConnectionString = item.HOST,
                            IsAutoCloseConnection = true,
                            DbType = (DbType)Enum.Parse(typeof(DbType), item.DataType)
                        }
                    );
                }

                //SqlSugarClient client = new SqlSugarClient(configs);

                SqlSugarScope client = new SqlSugarScope(
                    configs,
                    cli =>
                    {
                        cli.Aop.OnLogExecuting = (s, p) =>
                        {
                            Console.WriteLine(
                                "*******************************************************************************************"
                            );
                            Console.WriteLine(
                                $"OnLogExecuting:輸出Sql語句:{s} || 參數為：{string.Join(",", p.Select(p => p.Value))}"
                            );
                        };

                        //cli.Aop.DataExecuting = (s, p) =>
                        //{
                        //    if (
                        //        p.OperationType.Equals(DataFilterType.InsertByObject)
                        //        && "CreateTime".Equals(p.EntityColumnInfo.DbColumnName)
                        //    )
                        //    {
                        //        p.SetValue(DateTime.Now);
                        //    }

                        //    if (
                        //        p.OperationType.Equals(DataFilterType.UpdateByObject)
                        //        && "ModifyTime".Equals(p.EntityColumnInfo.DbColumnName)
                        //    )
                        //    {
                        //        p.SetValue(DateTime.Now);
                        //    }
                        //};

                        //cli.Aop.OnLogExecuted = (s, p) =>
                        //{
                        //    Console.WriteLine(
                        //        "*******************************************************************************************"
                        //    );
                        //    Console.WriteLine(
                        //        $"OnLogExecuted:輸出Sql語句:{s} || 參數為：{string.Join(",", p.Select(p => p.Value))}"
                        //    );
                        //};
                        //cli.Aop.OnError = e =>
                        //{
                        //    Console.WriteLine(
                        //        "*******************************************************************************************"
                        //    );
                        //    Console.WriteLine($"OnError:Sql語句執行異常:{e.Message}");
                        //};
                    }
                );

                return client;
            });
        }

        /// <summary>
        /// 第二種註冊法 初始化SqlSugar services.InitSqlSugar2();
        /// </summary>
        /// <param name="services"></param>
        /// <exception cref="Exception"></exception>
        public static void InitSqlSugar2(this IServiceCollection services)
        {
            services.AddSingleton(ServiceProvider =>
            {
                var config = ServiceProvider.GetRequiredService<List<DBConnectionSet>>();
                if (config == null)
                {
                    throw new Exception("No Connection config");
                }
                List<ConnectionConfig> configs = new List<ConnectionConfig>();

                foreach (var item in config)
                {
                    configs.Add(
                        new ConnectionConfig()
                        {
                            ConfigId = item.DBBASE,
                            ConnectionString = item.HOST,
                            IsAutoCloseConnection = true,
                            DbType = (DbType)Enum.Parse(typeof(DbType), item.DataType)
                        }
                    );
                }

                //SqlSugarClient client = new SqlSugarClient(configs);

                SqlSugarScope client = new SqlSugarScope(
                    configs,
                    cli =>
                    {
                        cli.Aop.OnLogExecuting = (s, p) =>
                        {
                            Console.WriteLine(
                                "*******************************************************************************************"
                            );
                            Console.WriteLine(
                                $"OnLogExecuting:輸出Sql語句:{s} || 參數為：{string.Join(",", p.Select(p => p.Value))}"
                            );
                        };

                        //cli.Aop.DataExecuting = (s, p) =>
                        //{
                        //    if (
                        //        p.OperationType.Equals(DataFilterType.InsertByObject)
                        //        && "CreateTime".Equals(p.EntityColumnInfo.DbColumnName)
                        //    )
                        //    {
                        //        p.SetValue(DateTime.Now);
                        //    }

                        //    if (
                        //        p.OperationType.Equals(DataFilterType.UpdateByObject)
                        //        && "ModifyTime".Equals(p.EntityColumnInfo.DbColumnName)
                        //    )
                        //    {
                        //        p.SetValue(DateTime.Now);
                        //    }
                        //};

                        //cli.Aop.OnLogExecuted = (s, p) =>
                        //{
                        //    Console.WriteLine(
                        //        "*******************************************************************************************"
                        //    );
                        //    Console.WriteLine(
                        //        $"OnLogExecuted:輸出Sql語句:{s} || 參數為：{string.Join(",", p.Select(p => p.Value))}"
                        //    );
                        //};
                        //cli.Aop.OnError = e =>
                        //{
                        //    Console.WriteLine(
                        //        "*******************************************************************************************"
                        //    );
                        //    Console.WriteLine($"OnError:Sql語句執行異常:{e.Message}");
                        //};
                    }
                );

                return client;
            });

        }



    }
}
