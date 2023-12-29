using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///變數
    ///</summary>
    [SugarTable("parameter")]
    public partial class parameter
    {
           public parameter(){


           }
           /// <summary>
           /// Desc:變數編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object ParameterID {get;set;}

           /// <summary>
           /// Desc:變數名稱
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:變數值
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Value {get;set;}

           /// <summary>
           /// Desc:變數描述
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Description {get;set;}

           /// <summary>
           /// Desc:建立時間
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime CreateTime {get;set;}

           /// <summary>
           /// Desc:建立者
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CreateUser {get;set;}

           /// <summary>
           /// Desc:最後異動時間
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime LastModifyTime {get;set;}

           /// <summary>
           /// Desc:最後異動者
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string LastModifyUser {get;set;}

    }
}
