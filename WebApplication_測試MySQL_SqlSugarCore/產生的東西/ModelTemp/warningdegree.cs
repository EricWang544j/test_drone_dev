using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///警報等級
    ///</summary>
    [SugarTable("warningdegree")]
    public partial class warningdegree
    {
           public warningdegree(){


           }
           /// <summary>
           /// Desc:警報等級ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object WarningDegreeID {get;set;}

           /// <summary>
           /// Desc:警報等級文字
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string WarningDegreeText {get;set;}

           /// <summary>
           /// Desc:警報顏色
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string WarningDegreeColor {get;set;}

           /// <summary>
           /// Desc:警報顯示方式  0:無 1:閃爍/間隔30秒
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public object WarningDegreeShowType {get;set;}

           /// <summary>
           /// Desc:警報聲音方式 0:無  1:有聲音
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public object WarningDegreeSoundType {get;set;}

           /// <summary>
           /// Desc:警報聲音檔路徑
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string WarningDegreeSoundPath {get;set;}

           /// <summary>
           /// Desc:警報聲音時間 預設8秒,下限1秒,上限100秒 
           /// Default:8
           /// Nullable:True
           /// </summary>           
           public object WarningDegreeSoundTimes {get;set;}

           /// <summary>
           /// Desc:排序
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int WarningDegreeSort {get;set;}

           /// <summary>
           /// Desc:建立者id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int WarningDegreeOperatorID {get;set;}

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
