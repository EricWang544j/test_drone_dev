using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///元件
    ///</summary>
    [SugarTable("element")]
    public partial class element
    {
           public element(){


           }
           /// <summary>
           /// Desc:元件編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object ElementID {get;set;}

           /// <summary>
           /// Desc:元件名稱
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ElementName {get;set;}

           /// <summary>
           /// Desc:元件類型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ElementType {get;set;}

           /// <summary>
           /// Desc:元件屬性
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ElementAttribute {get;set;}

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

           /// <summary>
           /// Desc:建立者編號
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ElementOperatorID {get;set;}

           /// <summary>
           /// Desc:元件檔案路徑
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ElementFilePath {get;set;}

    }
}
