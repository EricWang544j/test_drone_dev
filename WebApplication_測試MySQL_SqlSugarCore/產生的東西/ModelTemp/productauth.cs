using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///產品授權
    ///</summary>
    [SugarTable("productauth")]
    public partial class productauth
    {
           public productauth(){


           }
           /// <summary>
           /// Desc:id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object ProductAuthID {get;set;}

           /// <summary>
           /// Desc:客戶名稱id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CustomerId {get;set;}

           /// <summary>
           /// Desc:加密文
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AllCipherText {get;set;}

           /// <summary>
           /// Desc:加密文2
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AllCipherText2 {get;set;}

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
