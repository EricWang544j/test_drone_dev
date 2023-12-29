using SqlSugar;

namespace WebApplication_測試MySQL_SqlSugarCore.ForHelper
{
    public class HelperSqlSugarConnection
    {
        public SqlSugarScope SqlSugarClient { get; private set; }

        public HelperSqlSugarConnection(string connectionString, DbType dtype)
        {
            ConnectionConfig connectionConfig = new ConnectionConfig()
            {
                ConnectionString = connectionString,
                IsAutoCloseConnection = true,
                DbType = dtype
            };

            List<ConnectionConfig> configs = new List<ConnectionConfig>();
            configs.Add(connectionConfig);

            SqlSugarClient = new SqlSugarScope(
                configs,
                cli =>
                {
                    cli.Aop.OnLogExecuting = (s, p) => {
#if false  //印sql
                            #region 印sql
                            Console.WriteLine(
                                "*******************************************************************************************"
                            );
                            Console.WriteLine(
                                $"OnLogExecuting:輸出Sql語句:{s} || 參數為：{string.Join(",", p.Select(p => p.Value))}"
                            );
                            #endregion
#endif
                    };
                }
            );
        }
    }
}
