using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///操作者登入紀錄
    ///</summary>
    [SugarTable("operatorloginlogoutlog")]
    public partial class operatorloginlogoutlog
    {
           public operatorloginlogoutlog(){


           }
           /// <summary>
           /// Desc:操作者登入紀錄編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object LogID {get;set;}

           /// <summary>
           /// Desc:時間戳記
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object Timestamp {get;set;}

           /// <summary>
           /// Desc:序列編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string SerialNo {get;set;}

           /// <summary>
           /// Desc:操作者編號
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public object OperatorID {get;set;}

           /// <summary>
           /// Desc:帳號
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Account {get;set;}

           /// <summary>
           /// Desc:語系
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Language {get;set;}

           /// <summary>
           /// Desc:時區
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TimeZone {get;set;}

           /// <summary>
           /// Desc:IP
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IP {get;set;}

           /// <summary>
           /// Desc:地區
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Location {get;set;}

           /// <summary>
           /// Desc:來源
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Origin {get;set;}

           /// <summary>
           /// Desc:用戶代理
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UserAgent {get;set;}

           /// <summary>
           /// Desc:內文
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Content {get;set;}

           /// <summary>
           /// Desc:驗證碼
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Token {get;set;}

           /// <summary>
           /// Desc:刷新驗證碼
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RefreshToken {get;set;}

           /// <summary>
           /// Desc:登入時間
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? LoginTime {get;set;}

           /// <summary>
           /// Desc:登出時間
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? LogoutTime {get;set;}

    }
}
