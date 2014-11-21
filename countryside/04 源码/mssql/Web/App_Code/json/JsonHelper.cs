using System;
using System.Collections.Generic;
using System.Web;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
/// <summary>
///jsonhelper 的摘要说明
/// </summary>
public class JsonHelper
{
    #region 将对象转化为JSON字符串
    /// <summary>
    /// 将对象转化为JSON字符串
    /// </summary>
    /// <typeparam name="T">源类型</typeparam>
    /// <param name="instance">源类型实例</param>
    /// <returns>JSON 字符串</returns>
    public static string ObjectToJson<T>(T instance)
    {
        string result = "";
        //创建指定类型的JSON序列化器
        DataContractJsonSerializer jsonserializer = new DataContractJsonSerializer(typeof(T));
        //将对象的序列化为JSON格式的Stream
        MemoryStream stream = new MemoryStream();
        jsonserializer.WriteObject(stream, instance);
        stream.Position = 0; //读取stream
        StreamReader sr = new StreamReader(stream);
        result = sr.ReadToEnd();
        return result;
    }
    #endregion

    #region 将JSON字符串转化为对象
    /// <summary>
    /// 将JSON字符串转化为对象
    /// </summary>
    /// <typeparam name="T">目标对象</typeparam>
    /// <param name="jsonstring">JSON字符串</param>
    /// <returns>目标类型的一个实例</returns>
    public static T JsonToObject<T>(string jsonstring)
    {
        T result;
        //创建指定类型的JSON序列化器 
        DataContractJsonSerializer jsonserializer = new DataContractJsonSerializer(typeof(T));
        //将JSON字符串放入Stream
        byte[] jsonBytes = new UTF8Encoding().GetBytes(jsonstring);
        MemoryStream stream = new MemoryStream(jsonBytes);
        //使用JSON序列化器将stream转化为对象
        result = (T)jsonserializer.ReadObject(stream);
        return result;
    }
    #endregion

    #region 序列化
    /// <summary>  
    /// 序列化  
    /// </summary>  
    /// <param name="obj"></param>  
    /// <returns></returns>  
    public static string SerializeObject(object obj)
    {
        return JsonConvert.SerializeObject(obj);
    }
    #endregion

    #region 反序列化
    /// <summary>  
    /// 反序列化  
    /// </summary>  
    /// <typeparam name="T"></typeparam>  
    /// <param name="value"></param>  
    /// <returns></returns>  
    public static T Deserialize<T>(string value)
    {
        try
        {
            return JsonConvert.DeserializeObject<T>(value);
        }
        catch
        {
            return default(T);
        }
    }
    #endregion  

    #region  获取JProperty 枚举集合

    public static IEnumerable<JProperty> GetJPropertyForJsonStr(string json)
    {
        IEnumerable<JProperty> proper = null;
        JObject o = ParseJson(json);
        if (o != null)
        {
            proper = o.Properties();
        }
        return proper;
    }


    /// <summary>
    /// 描述：解析JSON字符串为JObject对象
    /// 作者：王渝友
    /// 时间：2012-11-24
    /// </summary>
    /// <param name="json">json字符串</param>
    /// <returns>JObject对象</returns>
    public static JObject ParseJson(string json)
    {
        JObject o = null;
        try
        {
            o = JObject.Parse(json);
        }
        catch (Exception ex)
        {
            //WanerDaoLog4Net.Write("解析JSON字符串为JObject对象出错", WanerDaoLog4Net.LogMessageType.Error, ex);
            return null;
        }
        return o;
    }

    #endregion

    #region 从DataTalbe中获取json字符串
    /// <summary>
    /// 从DataTalbe中获取json字符串
    /// </summary>
    /// <param name="dt"></param>
    /// <returns></returns>
    public static string JsonFromDataTable(DataTable dt)
    {
        string json = string.Empty;
        Dictionary<string, object> result = new Dictionary<string, object>();
        if (dt != null && dt.Rows.Count > 0)
        {
            result.Add("table", DataTableToList(dt));
            json = JsonFromDictionary(result);
        }
        return json;
    }
    #endregion

    #region 数据表集合转换为List数据集合
    /// <summary>
    /// 描述：数据表集合转换为List数据集合
    /// 作者：王渝友
    /// 时间：2013-3-14
    /// </summary>
    /// <param name="dt">数据表集合</param>
    /// <returns>List数据集合</returns>
    public static List<Dictionary<string, object>> DataTableToList(DataTable dt)
    {
        List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
        if (dt == null || dt.Rows.Count < 1)
        {
            return null;
        }
        foreach (DataRow dr in dt.Rows)
        {
            Dictionary<string, object> dtJSON = new Dictionary<string, object>();
            foreach (DataColumn dc in dt.Columns)
            {
                object dcValue = dr[dc.ColumnName];
                if (dc.DataType == typeof(DateTime) && dcValue == DBNull.Value)
                { dcValue = DateTime.MinValue; }

                dtJSON.Add(dc.ColumnName, dcValue);
            }
            list.Add(dtJSON);
        }
        return list;
    }
    #endregion

    #region 数据集合转换为Json字符串
    /// <summary>
    /// 数据集合转换为Json字符串
    /// </summary>
    /// <param name="prepareJson"></param>
    /// <returns></returns>
    private static string JsonFromDictionary(Dictionary<string, object> prepareJson)
    {
        string json = string.Empty;
        JObject so = new JObject();
        string listStr = "System.Collections.Generic.List`1[System.String]";
        foreach (KeyValuePair<string, object> dic in prepareJson)
        {
            if (dic.Value == null)
            {
                so.Add(new JProperty(dic.Key, ""));
                continue;
            }
            if (dic.Value.GetType().IsGenericType)
            {

                Type listType = dic.Value.GetType().GetInterface("IList");
                if (listType != null)
                {
                    Type t = dic.Value.GetType();
                    if (dic.Value.GetType() == Type.GetType(listStr))
                    {
                        JArray ja = new JArray();
                        List<string> strList = (List<string>)dic.Value;
                        foreach (string str in strList)
                        {
                            ja.Add(str);
                        }
                        so.Add(new JProperty(dic.Key, (JToken)ja));
                    }
                    else
                    {
                        List<Dictionary<string, object>> list = (List<Dictionary<string, object>>)dic.Value;
                        JArray ja = new JArray();
                        foreach (Dictionary<string, object> dicother in list)
                        {
                            JObject data = new JObject();
                            foreach (KeyValuePair<string, object> d in dicother)
                            {
                                if (string.IsNullOrEmpty(d.Value.ToString()))
                                    data.Add(new JProperty(d.Key, string.Empty));
                                else
                                    data.Add(new JProperty(d.Key, d.Value.ToString()));
                            }
                            ja.Add(data);
                        }
                        so.Add(new JProperty(dic.Key, (JToken)ja));
                    }
                }
                else
                {
                    Type dicType = dic.Value.GetType().GetInterface("IDictionary");
                    if (dicType != null)
                    {
                        Dictionary<string, object> dicother = (Dictionary<string, object>)dic.Value;
                        JArray ja = new JArray();
                        JObject data = new JObject();
                        foreach (KeyValuePair<string, object> d in dicother)
                        {
                            if (d.Value.GetType() == Type.GetType(listStr))
                            {
                                List<string> strList = (List<string>)d.Value;
                                JArray jastr = new JArray();
                                foreach (string str in strList)
                                {
                                    jastr.Add(str);
                                }
                                data.Add(new JProperty(d.Key, (JToken)jastr));
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(d.Value.ToString()))
                                    data.Add(new JProperty(d.Key, string.Empty));
                                else
                                    data.Add(new JProperty(d.Key, d.Value.ToString()));
                            }
                        }
                        ja.Add(data);
                        so.Add(new JProperty(dic.Key, (JToken)ja));
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(dic.Value.ToString()))
                    so.Add(new JProperty(dic.Key, string.Empty));
                else
                    so.Add(new JProperty(dic.Key, dic.Value.ToString()));
            }
        }
        json = JsonConvert.SerializeObject(so);
        return json;
    }
    #endregion

}