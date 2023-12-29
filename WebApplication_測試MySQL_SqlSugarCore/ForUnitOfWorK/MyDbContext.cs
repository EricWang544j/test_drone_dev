using SqlSugar;
using WebApplication_測試MySQL_SqlSugarCore.Models.Entity;

namespace WebApplication_測試MySQL_SqlSugarCore.ForUnitOfWorK
{
    public class MyDbContext : SugarUnitOfWork
    {
        public DbSet<parameter> parameter { get; set; }
        public DbSet<employee> employee { get; set; }
        

    }
    public class DbSet<T> : SimpleClient<T> where T : class, new()
    {
        //可以重写仓储方法
        //可以添加新方法
    }
}
