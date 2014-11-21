using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
 
/// <summary>
///Url 操作类
/// </summary>
public class UrlOperation
{
    /// <summary>
    /// Url判定格式 正则
    /// </summary>
    public static string UrlDecidePattern = @"\]*=(\w*)";
 


    #region URL解码
    /// <summary>
    /// 描述：URL解码
    /// 作者：王渝友
    /// 时间：2012-11-15
    /// </summary>
    /// <param name="data">传递参数</param>
    /// <returns>解码后的URL参数</returns>
    public static string UrlDecode(string data)
    {
        return HttpUtility.UrlDecode(data);
    }
    #endregion

    #region 判断是否是请求的Url
    /// <summary>
    /// 判断是否是请求的Url
    /// </summary>
    /// <param name="param"></param>
    /// <returns></returns>
    public static bool DecideUrlParam(string param)
    {
        bool flg = false;
        Regex reg = new Regex(UrlDecidePattern, RegexOptions.IgnoreCase);
        MatchCollection matches = reg.Matches(param);
        if (matches.Count > 0)
        {
            flg = true;
        }
        return flg;
    }
    #endregion


  
}