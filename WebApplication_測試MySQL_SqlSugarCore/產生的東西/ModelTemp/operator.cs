using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///操作者
    ///</summary>
    [SugarTable("operator")]
    public partial class operator
    {
           public operator(){


           }
           /// <summary>
           /// Desc:操作者編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object OperatorID {get;set;}

           /// <summary>
           /// Desc:操作者類型 0:系統管理者, 1:一般操作者
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public object OperatorType {get;set;}

           /// <summary>
           /// Desc:帳號
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Account {get;set;}

           /// <summary>
           /// Desc:密碼
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Password {get;set;}

           /// <summary>
           /// Desc:加密
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Salt {get;set;}

           /// <summary>
           /// Desc:姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:信箱
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Email {get;set;}

           /// <summary>
           /// Desc:上階操作者編號
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public object ParentOperatorID {get;set;}

           /// <summary>
           /// Desc:操作者狀態 -1:刪除 0:停用, 1:啟用, 2:鎖定, 3:凍結
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
