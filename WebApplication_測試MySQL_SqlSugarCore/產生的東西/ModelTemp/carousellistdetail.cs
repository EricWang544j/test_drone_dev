using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Models
{
    ///<summary>
    ///輪播清單明細
    ///</summary>
    [SugarTable("carousellistdetail")]
    public partial class carousellistdetail
    {
           public carousellistdetail(){


           }
           /// <summary>
           /// Desc:輪播清單明細編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public object CarouselListDetailId {get;set;}

           /// <summary>
           /// Desc:輪播編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object CarouselListID {get;set;}

           /// <summary>
           /// Desc:畫布編號
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object CarouselCanvasID {get;set;}

           /// <summary>
           /// Desc:畫布播放時間單位(s秒m分h時) 預設m
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CarouselListDetailPlayUnit {get;set;}

           /// <summary>
           /// Desc:畫布播放時間數字 預設10 
           /// Default:
           /// Nullable:False
           /// </summary>           
           public object CarouselListDetailPlayTime {get;set;}

           /// <summary>
           /// Desc:排序
           /// Default:99999
           /// Nullable:False
           /// </summary>           
           public double CarouselListDetailSort {get;set;}

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
