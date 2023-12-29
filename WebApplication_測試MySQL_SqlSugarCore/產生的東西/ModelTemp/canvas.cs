using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///畫布
    ///</summary>
    [SugarTable("canvas")]
    public partial class canvas
    {
           public canvas(){


           }
           /// <summary>
           /// Desc:畫布編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object CanvasID {get;set;}

           /// <summary>
           /// Desc:畫布名稱
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CanvasName {get;set;}

           /// <summary>
           /// Desc:文字
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CanvasText {get;set;}

           /// <summary>
           /// Desc:文字屬性
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CanvasTextAttribute {get;set;}

           /// <summary>
           /// Desc:解析度高
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object CanvasResolutionH {get;set;}

           /// <summary>
           /// Desc:解析度寬
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int CanvasResolutionW {get;set;}

           /// <summary>
           /// Desc:畫布顏色
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CanvasColor {get;set;}

           /// <summary>
           /// Desc:畫布屬性
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CanvasAttribute {get;set;}

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
           public int? CanvasOperatorID {get;set;}

    }
}
