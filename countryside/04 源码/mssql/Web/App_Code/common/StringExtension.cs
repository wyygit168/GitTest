using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// String 扩展操作类
/// </summary>
public class StringExtension
{
    #region 分割字符串
    /// <summary>
    /// 描述：分割字符串
    /// 作者：王渝友
    /// 时间：2012-11-24
    /// </summary>
    /// <param name="source">源字符串</param>
    /// <param name="splitchar">分割字符</param>
    /// <returns></returns>
    public static string[] ParseArray(string source, params char[] splitchar)
    {
        return source.Split(splitchar);
    }
    #endregion

    #region 移除引用 如\' \"
    /// <summary>
    /// 描述：移除引用 如\' \"
    /// 作者：王渝友
    /// 时间：2012-11-24
    /// </summary>
    /// <param name="data">参数</param>
    /// <returns>替换引用</returns>
    public static string RemoveQuotation(string data)
    {
        //return data.Replace("\"", "").Replace("'", "").Trim();
        return data.Trim("\'\"".ToCharArray());
    }

    #endregion
}