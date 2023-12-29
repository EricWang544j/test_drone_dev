using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///警報訊息
    ///</summary>
    [SugarTable("warningalarm")]
    public partial class warningalarm
    {
           public warningalarm(){


           }
           /// <summary>
           /// Desc:警報消息ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object WarningAlarmID {get;set;}

           /// <summary>
           /// Desc:警報等級編號
           /// Default:
           /// Nullable:False
           /// </summary>           
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
           /// Desc:變數編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object WarningSetDataColumnID {get;set;}

           /// <summary>
           /// Desc:資料欄位名稱
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string WarningSetDataColumnName {get;set;}

           /// <summary>
           /// Desc:當下數值
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string WarningAlarmValue {get;set;}

           /// <summary>
           /// Desc:發生時間
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime WarningAlarmHappenTime {get;set;}

           /// <summary>
           /// Desc:處理時間
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? WarningAlarmHandlingTime {get;set;}

           /// <summary>
           /// Desc:是否已處理 1-已處理/2-未處理
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object WarningAlarmHandleState {get;set;}

           /// <summary>
           /// Desc:警報設定規則編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object WarningSetRulesID {get;set;}

           /// <summary>
           /// Desc:警報描述
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string WarningSetRulesDescript {get;set;}

           /// <summary>
           /// Desc:警報處理人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public object WarningAlarmHandlingManID {get;set;}

           /// <summary>
           /// Desc:警報處理人帳號
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WarningAlarmHandlingManAccount {get;set;}

           /// <summary>
           /// Desc:處理方式  (後台點選)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WarningAlarmHandleMode {get;set;}

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
