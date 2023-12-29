using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///假資料
    ///</summary>
    [SugarTable("xdatap2")]
    public partial class xdatap2
    {
           public xdatap2(){


           }
           /// <summary>
           /// Desc:編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object xDataP2ID {get;set;}

           /// <summary>
           /// Desc:X軸
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int xDataP2Xaxis {get;set;}

           /// <summary>
           /// Desc:Y軸
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int xDataP2Yaxis {get;set;}

           /// <summary>
           /// Desc:建立時間
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? P2CreateTime {get;set;}

    }
}
