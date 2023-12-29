using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///警報設定規則
    ///</summary>
    [SugarTable("warningsetrules")]
    public partial class warningsetrules
    {
           public warningsetrules(){


           }
           /// <summary>
           /// Desc:警報設定規則 編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object WarningSetRulesID {get;set;}

           /// <summary>
           /// Desc:警報設定 編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object WarningSetID {get;set;}

           /// <summary>
           /// Desc:警報等級 編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object WarningSetWarningDegreeID {get;set;}

           /// <summary>
           /// Desc:警報描述
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string WarningSetRulesDescript {get;set;}

           /// <summary>
           /// Desc:判斷式規則類型,0:大於>,1:小於<,2:等於=,3:之間
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int WarningSetRulesRulesType {get;set;}

           /// <summary>
           /// Desc:判斷式值1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WarningSetRulesValue1 {get;set;}

           /// <summary>
           /// Desc:判斷式值2
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WarningSetRulesValue2 {get;set;}

           /// <summary>
           /// Desc:判斷式值3
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WarningSetRulesValue3 {get;set;}

           /// <summary>
           /// Desc:判斷式值4
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WarningSetRulesValue4 {get;set;}

           /// <summary>
           /// Desc:排序
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int WarningSetRulesSetSort {get;set;}

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
