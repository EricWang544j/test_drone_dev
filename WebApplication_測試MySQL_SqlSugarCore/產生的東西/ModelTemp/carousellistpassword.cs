using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///輪播密碼列表
    ///</summary>
    [SugarTable("carousellistpassword")]
    public partial class carousellistpassword
    {
           public carousellistpassword(){


           }
           /// <summary>
           /// Desc:輪播密碼列表編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object CarouselListPassWordID {get;set;}

           /// <summary>
           /// Desc:輪播編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object CarouselListID {get;set;}

           /// <summary>
           /// Desc:輪播網址
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CarouselListPassWordURL {get;set;}

           /// <summary>
           /// Desc:輪播帳號(建網址用)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CarouselListAccount {get;set;}

           /// <summary>
           /// Desc:輪播密碼
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CarouselListPWD {get;set;}

           /// <summary>
           /// Desc:輪播密碼建立人id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object CarouselListPasswordOperatorID {get;set;}

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
