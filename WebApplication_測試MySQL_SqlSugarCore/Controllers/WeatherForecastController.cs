using Microsoft.AspNetCore.Mvc;
using SqlSugar;
using WebApplication_測試MySQL_SqlSugarCore.ForHelper;
using WebApplication_測試MySQL_SqlSugarCore.ForUnitOfWorK;
using WebApplication_測試MySQL_SqlSugarCore.Models.Entity;

namespace WebApplication_測試MySQL_SqlSugarCore.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing",
            "Bracing",
            "Chilly",
            "Cool",
            "Mild",
            "Warm",
            "Balmy",
            "Hot",
            "Sweltering",
            "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        private SqlSugarScope _client;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            SqlSugarScope client
        )
        {
            _logger = logger;
            _client = client;
        }

        /// <summary>
        /// 產生Entity
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "buildEntity")]
        public OkResult buildEntity()
        {
            string baseDir =
                "D:\\code\\43_程式碼產生器\\WebApplication_測試MySQL_SqlSugarCore\\WebApplication_測試MySQL_SqlSugarCore\\產生的東西\\";

            string BuildPath = @$"{baseDir}\ModelTemp";
            var temp = _client.DbFirst;

            //temp = temp.SettingPropertyDescriptionTemplate(old =>
            //    {
            //        return old
            //            + "\r\n [Required(ErrorMessage = \"請輪入{0}\") ] "
            //            + "\r\n [Display(Name = \"{PropertyDescription}\")] "
            //            + "\r\n [DisplayName(\"{PropertyDescription}\")] ";
            //    })
            //    .SettingNamespaceTemplate(old =>
            //    {
            //        return old
            //            + "\r\n using System.ComponentModel;  "
            //            + "\r\n using System.ComponentModel.DataAnnotations; ";
            //        //追加引用SqlSugar
            //    });


            temp.IsCreateAttribute();

            temp.CreateClassFile(BuildPath);

            return Ok();
        }

        /// <summary>
        /// di client查詢
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "QueryFromDI")]
        public List<parameter> QueryFromDI()
        {
            var list = _client.Queryable<parameter>().ToList();

            return list;
        }

        /// <summary>
        /// Helper client查詢
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "DBFromUnitOfWorK")]
        public OkResult DBFromUnitOfWorK()
        {

            try
            {
                using (var uow = _client.CreateContext<MyDbContext>())
                {

                    parameter modelDbParameter = new parameter();
                    //modelDbParameter.ParameterID = 101;
                    modelDbParameter.Name = "test";
                    modelDbParameter.Value = "test";
                    modelDbParameter.Description = "Description";
                    modelDbParameter.CreateUser = "test";
                    modelDbParameter.LastModifyUser = "test";
                    modelDbParameter.LastModifyTime = DateTime.Now;
                    modelDbParameter.CreateTime = DateTime.Now;
                    uow.parameter.Insert(modelDbParameter);


                    employee employee = new employee();
                    // 設定屬性值
                    //employee.EmployeeID = 1;
                    employee.EmployeeName = "John Doe";
                    employee.EmployeeEmail = "john.doe@example.com";
                    employee.EmployeePhoneNumber = "123-456-7890";
                    //employee.CreateTime = DateTime.Now;
                    //employee.CreateUser = "nices017";
                    //employee.LastModifyTime = DateTime.Now;
                    //employee.LastModifyUser = "nices017";
                    uow.employee.Insert(employee);

                    uow.Commit();
                }

            }
            catch (Exception)
            {

                throw;
            }

            //   var list = client.Queryable<parameter>().ToList();

            return Ok();
        }

        /// <summary>
        /// Helper client查詢
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "QueryFromHelper")]
        public List<parameter> ClientQueryFromDI()
        {
            string connectionString =
                "server=127.0.0.1; port=3306;   database=Main; user=root; password=!QAZ2wsx; Pooling=true; Max Pool Size=200; sslmode=none; Allow User Variables=True; charset=utf8;";

            HelperSqlSugarConnection connection = new HelperSqlSugarConnection(
                connectionString,
                DbType.MySql
            );

            var client = connection.SqlSugarClient;

            var list = client.Queryable<parameter>().ToList();

            return list;
        }
    }
}
