using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///警報設定
    ///</summary>
    [SugarTable("warningset")]
    public partial class warningset
    {
           public warningset(){


           }
           /// <summary>
           /// Desc:警報設定編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object WarningSetID {get;set;}

           /// <summary>
           /// Desc:變數編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object WarningSetDataColumnID {get;set;}

           /// <summary>
           /// Desc:警報間隔
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object WarningSetInterval {get;set;}

           /// <summary>
           /// Desc:操作者編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object WarningSetOperatorID {get;set;}

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
