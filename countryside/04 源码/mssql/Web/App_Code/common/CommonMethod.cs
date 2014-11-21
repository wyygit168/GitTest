using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Text;
/// <summary>
///CommonMethod 的摘要说明
/// </summary>
public class CommonMethod
{

    #region 转换为int类型
    /// <summary>
    /// 转换为int类型
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="defaultValue">返回的默认值</param>
    /// <param name="numStyle">数字格式</param>
    /// <returns></returns>
    public static int ConvertToInt(object obj, int defaultValue, NumberStyles numStyle)
    {
        int result = defaultValue;
        if (obj != null && obj != DBNull.Value)
        {
            if (!int.TryParse(obj.ToString().Trim(), numStyle, null, out result))
            {
                result = defaultValue;
            }
        }
        return result;
    }

    /// <summary>
    /// 转换为int类型
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="defaultValue">返回的默认值</param>
    /// <returns></returns>
    public static int ConvertToInt(object obj, int defaultValue)
    {
        return CommonMethod.ConvertToInt(obj, defaultValue, NumberStyles.Number);
    }

    #endregion

    #region 转换为decimal类型
    /// <summary>
    /// 转换为decimal类型
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="defaultValue">返回的默认值</param>
    /// <returns></returns>
    public static decimal ConvertToDecimal(object obj, decimal defaultValue)
    {
        decimal result = defaultValue;
        if (obj != null && obj != DBNull.Value)
        {
            if (!decimal.TryParse(obj.ToString().Trim(), out result))
            {
                result = defaultValue;
            }
        }
        return result;
    }
    #endregion

    #region 转换状态值
    /// <summary>
    /// 转换为状态值 0为无效 1为有效
    /// </summary>
    /// <param name="strStatusId"></param>
    /// <returns></returns>
    public static string ConvertToStatus(string strStatusId)
    {
        string returnValue = "<span style='color:red;'>无效</span>";
        if (strStatusId.Equals("1")) returnValue = "<span style='color:green;'>有效</span>";
        return returnValue;
    }


    /// <summary>
    /// 转换为状态值 0为禁用 1为启用
    /// </summary>
    /// <param name="strStatusId"></param>
    /// <returns></returns>
    public static string ConvertToEnableStatus(string strStatusId)
    {
        string returnValue = "<span style='color:red;'>禁用</span>";
        if (strStatusId.Equals("1")) returnValue = "<span style='color:green;'>启用</span>";
        return returnValue;
    }

    /// <summary>
    /// 转换为域名状态值 0为未绑定 1为已绑定
    /// </summary>
    /// <param name="strStatusId"></param>
    /// <returns></returns>
    public static string ConvertToDomainStatus(string strStatusId)
    {
        string returnValue = "<span style='color:red;'>未绑定</span>";
        if (strStatusId.Equals("1")) returnValue = "<span style='color:green;'>已绑定</span>";
        return returnValue;
    }

    /// <summary>
    /// 转换为资讯类型值
    /// </summary>
    /// <param name="strStatusId"></param>
    /// <returns></returns>
    public static string ConvertToFarmingNewStatus(string strStatusId, string villageid,string villagename)
    {
        //0：法律法规，1：地方资讯
        string returnValue = "法律法规"; 
        if (strStatusId.Equals("1"))
        {
            if (villageid == "0") { returnValue = "最新公告"; }
            else { returnValue = string.Format("乡村资讯({0})",villagename); }
        }
        return returnValue;
    }
    /// <summary>
    /// 转换为权限开通状态值 0，2为开通权限 1为关闭权限
    /// </summary>
    /// <param name="strStatusId"></param>
    /// <returns></returns>
    //public static string ConvertToPurviewStatus(string strStatusId)
    //{
    //    string returnValue = "<span style='color:red;'>开通权限</span>";
    //    if (strStatusId.Equals("1")) returnValue = "<span style='color:green;'>关闭权限</span>";
    //    return returnValue;
    //}
    #endregion

    #region  根据webconfig的key 获取Value值
    /// <summary>
    /// 根据webconfig的key 获取值
    /// </summary>
    /// <param name="key">config Key</param>
    /// <returns>返回 value</returns>
    public static string GetConfigValueByKey(string key)
    {
        return ConfigurationManager.AppSettings[key].ToString();

    }
    #endregion

    #region 客户端输入字符串验证

    /// <summary>
    /// 客户端输入字符串验证
    /// </summary>
    /// <param name="text">客户端输入</param>    
    /// <returns>清理后的字符串</returns>
    public static string ClearInputText(string text)
    {
        if (string.IsNullOrEmpty(text))
            return string.Empty;
        text = text.Trim();
        if (string.IsNullOrEmpty(text))
            return string.Empty;

        text = Regex.Replace(text, "[\\s]{2,}", " ");	//移除两个以上的空格
        text = Regex.Replace(text, "(<[b|B][r|R]/*>)+|(<[p|P](.|\\n)*?>)", "\n");	//移除Br
        text = Regex.Replace(text, "(\\s*&[n|N][b|B][s|S][p|P];\\s*)+", " ");	//移除&nbsp;
        text = Regex.Replace(text, "<(.|\\n)*?>", string.Empty);	//移除其他一些标志
        text = text.Replace("'", "''");//防止注入
        text = text.Replace("<", string.Empty);
        text = text.Replace(">", string.Empty);
        return text;
    }

    /// <summary>
    /// 客户端输入字符串验证
    /// </summary>
    /// <param name="text">客户端输入</param>
    /// <param name="maxLength">最大长度</param>
    /// <returns>清理后的字符串</returns>
    public static string ClearInputText(string text, int maxLength)
    {
        if (string.IsNullOrEmpty(text))
            return string.Empty;
        text = text.Trim();
        if (text.Length > maxLength)
            text = text.Substring(0, maxLength);
        return ClearInputText(text);
    }
    #endregion
   
    #region 获取 js css 版本号
    /// <summary>
    /// js css 版本控制号
    /// </summary>
    public static string Version
    {
        get
        {
            return GetConfigValueByKey("Ver");

        }
    }
    #endregion

    #region 输出字符串
    public static void ResponseContent(string Content)
    {
        HttpContext.Current.Response.Clear();
        HttpContext.Current.Response.ContentType = "text/xml";
        HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.GetEncoding("GB2312");
        HttpContext.Current.Response.Write(Content);
        HttpContext.Current.Response.End();
    }
    #endregion

    #region 截取字符串操作
    /// <summary>
    /// 截取字符串，获取指定字符长度（判断1中文字符为2字符）
    /// </summary>
    /// <param name="stringToSub">源字符串</param>
    /// <param name="length">长度</param>
    /// <param name="endstring">如果截断则显示的字符</param>
    /// <returns></returns>
    public static string GetSubString(string stringToSub, int length, string endstring)
    {
        if (!string.IsNullOrEmpty(stringToSub))
        {
            Regex regex = new Regex("[\u4e00-\u9fa5]+", RegexOptions.Compiled);
            Regex regexq = new Regex("[^\x00-\xff]+", RegexOptions.Compiled);
            char[] stringChar = stringToSub.ToCharArray();
            StringBuilder sb = new StringBuilder();
            int nLength = 0;
            bool isCut = false;
            for (int i = 0; i < stringChar.Length; i++)
            {
                if (regex.IsMatch((stringChar[i]).ToString()) || regexq.IsMatch((stringChar[i]).ToString()))
                {
                    sb.Append(stringChar[i]);
                    nLength += 2;
                }
                else
                {
                    sb.Append(stringChar[i]);
                    nLength = nLength + 1;
                }

                if (nLength > length)
                {
                    isCut = true;
                    break;
                }
            }
            if (isCut)
                return sb.ToString() + endstring;
            else
                return sb.ToString();
        }
        else
        {
            return string.Empty;
        }
    }
    #endregion

    #region 过滤HTML标签
    /// <summary>
    /// 过滤HTML标签
    /// </summary>
    /// <param name="Html"></param>
    /// <returns></returns>
    public static string RemoveHtmlTags(string Html)
    {
        Html = Regex.Replace(Html, "<script[^>]*?>.*?</script>", "", RegexOptions.IgnoreCase);
        Html = Regex.Replace(Html, "<[^>]*>", "", RegexOptions.IgnoreCase);
        return Html;
    }
    #endregion 

   
}