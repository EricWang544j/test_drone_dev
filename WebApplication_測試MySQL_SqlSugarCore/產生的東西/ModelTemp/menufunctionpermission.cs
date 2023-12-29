using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///選單函式權限
    ///</summary>
    [SugarTable("menufunctionpermission")]
    public partial class menufunctionpermission
    {
           public menufunctionpermission(){


           }
           /// <summary>
           /// Desc:選單編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public object MenuID {get;set;}

           /// <summary>
           /// Desc:選單函式編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object MenuFunctionID {get;set;}

           /// <summary>
           /// Desc:角色編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public object RoleID {get;set;}

           /// <summary>
           /// Desc:狀態 0:關閉, 1:啟用
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public object Status {get;set;}

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
