using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///員工
    ///</summary>
    [SugarTable("employee")]
    public partial class employee
    {
           public employee(){


           }
           /// <summary>
           /// Desc:員工編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object EmployeeID {get;set;}

           /// <summary>
           /// Desc:員工姓名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string EmployeeName {get;set;}

           /// <summary>
           /// Desc:員工信箱
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string EmployeeEmail {get;set;}

           /// <summary>
           /// Desc:員工電話
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string EmployeePhoneNumber {get;set;}

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
