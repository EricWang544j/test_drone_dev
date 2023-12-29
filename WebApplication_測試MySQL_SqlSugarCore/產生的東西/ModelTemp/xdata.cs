using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///假資料
    ///</summary>
    [SugarTable("xdata")]
    public partial class xdata
    {
           public xdata(){


           }
           /// <summary>
           /// Desc:畫布編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object xDataID {get;set;}

           /// <summary>
           /// Desc:X軸
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int xDataXaxis {get;set;}

           /// <summary>
           /// Desc:Y軸
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int xDataYaxis {get;set;}

           /// <summary>
           /// Desc:建立時間
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateTime {get;set;}

    }
}
