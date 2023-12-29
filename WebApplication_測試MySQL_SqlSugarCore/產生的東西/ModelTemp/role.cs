using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///角色
    ///</summary>
    [SugarTable("role")]
    public partial class role
    {
           public role(){


           }
           /// <summary>
           /// Desc:角色編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object RoleID {get;set;}

           /// <summary>
           /// Desc:角色類型  總管理者0   母角色1   子角色2
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int RoleType {get;set;}

           /// <summary>
           /// Desc:角色名稱
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string RoleName {get;set;}

           /// <summary>
           /// Desc:角色的上層編號，總管理者為-1
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int RoleParentID {get;set;}

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
