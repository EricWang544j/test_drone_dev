using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///選單API
    ///</summary>
    [SugarTable("menufunctionapi")]
    public partial class menufunctionapi
    {
           public menufunctionapi(){


           }
           /// <summary>
           /// Desc:選單API編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object MenuFunctionAPIID {get;set;}

           /// <summary>
           /// Desc:選單函式編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object MenuFunctionID {get;set;}

           /// <summary>
           /// Desc:API方法
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string MenuFunctionAPIMethod {get;set;}

           /// <summary>
           /// Desc:APIAction 全大寫
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string MenuFunctionAPIAction {get;set;}

           /// <summary>
           /// Desc:API方法描述
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string MenuFunctionAPIDescription {get;set;}

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
