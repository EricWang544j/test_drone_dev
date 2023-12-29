using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///群組與操作者
    ///</summary>
    [SugarTable("groupdivisionemployeemap")]
    public partial class groupdivisionemployeemap
    {
           public groupdivisionemployeemap(){


           }
           /// <summary>
           /// Desc:組編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public object GroupDivisionID {get;set;}

           /// <summary>
           /// Desc:操作者編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public object EmployeeID {get;set;}

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
