using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

/// <summary>
///扩展方法
/// </summary>
public static class ExtensionMethod
{
    #region 转换为int类型

    /// <summary>
    /// 转换为int类型
    /// </summary>
    /// <param name="defaultValue">默认值</param>
    /// <returns></returns>
    public static int ToInt(this object obj, int defaultValue)
    {
        int result = defaultValue;
        if (obj != null && obj != DBNull.Value)
        {
            if (!int.TryParse(obj.ToString().Trim(), NumberStyles.Number, null, out result))
            {
                result = defaultValue;
            }
        }
        return result;
    }

    /// <summary>
    /// 转换为int 类型
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static int ToInt(this object obj)
    {
       return ToInt(obj,0);
    } 
    #endregion
}
