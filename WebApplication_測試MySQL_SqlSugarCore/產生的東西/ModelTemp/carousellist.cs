using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///輪播清單
    ///</summary>
    [SugarTable("carousellist")]
    public partial class carousellist
    {
           public carousellist(){


           }
           /// <summary>
           /// Desc:輪播編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object CarouselListId {get;set;}

           /// <summary>
           /// Desc:輪播名稱 不可以用空格、特殊符號，最多輸入100字
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CarouselListName {get;set;}

           /// <summary>
           /// Desc:操作者編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object CarouselListOperatorID {get;set;}

           /// <summary>
           /// Desc:是否循環播放
           /// Default:b'1'
           /// Nullable:False
           /// </summary>           
           public bool CarouselListIsAutoPlay {get;set;}

           /// <summary>
           /// Desc:縮圖貼圖型態如：image/jpeg
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CarouselListThumbnailType {get;set;}

           /// <summary>
           /// Desc:縮圖貼圖
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CarouselListThumbnail {get;set;}

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
