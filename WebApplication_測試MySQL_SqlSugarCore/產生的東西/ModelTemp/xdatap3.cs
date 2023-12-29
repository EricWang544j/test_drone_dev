using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///假資料
    ///</summary>
    [SugarTable("xdatap3")]
    public partial class xdatap3
    {
           public xdatap3(){


           }
           /// <summary>
           /// Desc:編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object xDataP3ID {get;set;}

           /// <summary>
           /// Desc:X軸
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int xDataP3Xaxis {get;set;}

           /// <summary>
           /// Desc:Y軸
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int xDataP3Yaxis {get;set;}

           /// <summary>
           /// Desc:建立時間
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? P3CreateTime {get;set;}

    }
}
