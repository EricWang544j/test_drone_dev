using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///畫布元件對映
    ///</summary>
    [SugarTable("canvaselementmap")]
    public partial class canvaselementmap
    {
           public canvaselementmap(){


           }
           /// <summary>
           /// Desc:Map編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object CanvasElementMapID {get;set;}

           /// <summary>
           /// Desc:畫布編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object CanvasID {get;set;}

           /// <summary>
           /// Desc:元件編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object ElementID {get;set;}

           /// <summary>
           /// Desc:畫布下的元件屬性
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CanvasElementAttribute {get;set;}

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
