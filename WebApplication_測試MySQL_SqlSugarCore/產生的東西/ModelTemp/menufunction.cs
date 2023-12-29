using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///選單函式
    ///</summary>
    [SugarTable("menufunction")]
    public partial class menufunction
    {
           public menufunction(){


           }
           /// <summary>
           /// Desc:選單函式編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object MenuFunctionID {get;set;}

           /// <summary>
           /// Desc:選單編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object MenuID {get;set;}

           /// <summary>
           /// Desc:名稱
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:名稱(英)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string EName {get;set;}

           /// <summary>
           /// Desc:關鍵字
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Keyword {get;set;}

           /// <summary>
           /// Desc:語系對應
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string MultilingualismMapping {get;set;}

           /// <summary>
           /// Desc:圖示
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Icon {get;set;}

           /// <summary>
           /// Desc:描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Description {get;set;}

           /// <summary>
           /// Desc:擴充
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Extension {get;set;}

           /// <summary>
           /// Desc:狀態 0:關閉, 1:啟用
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public object Status {get;set;}

           /// <summary>
           /// Desc:加權
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object Weighting {get;set;}

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
