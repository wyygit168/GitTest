using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using System.Data;
public class ControlAndValue
{
    /// <summary>
    /// 通过反射机制和泛型设置控件的值
    /// </summary>
    /// <param name="parentControl"></param>
    public static void GetValues4Control<T>(Control parentControl, T t)
    {
        Type type = t.GetType();
        foreach (Control var in parentControl.Controls)
        {
            if (var.ID != null && var.ID.Contains("txt"))
            {
                TextBox box = var as TextBox;

                if (box != null)
                {
                    // 获取相对应的表明
                    string propertyName = var.ID.Substring(3);

                    PropertyInfo info = type.GetProperty(propertyName);
                    if (info != null)
                    {
                        box.Text = info.GetValue(t, null).ToString();
                    }
                    else
                    {
                        box.Text = "";
                    }
                }
            }
            else if (var.ID != null && var.ID.Contains("ddl"))
            {
                DropDownList list = var as DropDownList;
                if (list != null)
                {
                    string propertyName = var.ID.Substring(3);

                    PropertyInfo info = type.GetProperty(propertyName);
                    if (info != null)
                    {

                        list.SelectedValue = info.GetValue(t, null).ToString();
                    }
                    //else
                    //{
                    //    list.SelectedValue = "";
                    //}

                }
            }


        }
    }
     
    
    /// <summary>
    /// 通过反射机制和泛型从控件中获取控件的值，然后对数据对象进行赋值
    /// </summary>
    /// <param name="parentControl"></param>
    public static void SetValues4Controls<T>(Control parentControl, T t)
    {
        Type type = t.GetType();
        foreach (Control var in parentControl.Controls)
        {
            if (var.ID != null && var.ID.Contains("txt"))//TextBox控件获取值
            {
                TextBox box = var as TextBox;
                if (box != null)
                {
                    string propertyName = var.ID.Substring(3);// 获取相对应的表明
                    PropertyInfo info = type.GetProperty(propertyName);
                    if (info != null)
                    { 
                        SetValueToPropertyInfo(info, box.Text, t);
                    }
                }
            }
            else  if (var.ID != null && var.ID.Contains("ddl")) //下拉列表获取值
            {
                DropDownList list = var as DropDownList;
                if (list != null)
                {
                    string propertyName = var.ID.Substring(3);
                    PropertyInfo info = type.GetProperty(propertyName);
                    if (info != null)
                    {
                        SetValueToPropertyInfo(info, list.SelectedValue, t);
                    }

                }
            }
        }

    }

    public static void SetValueToPropertyInfo<T>(PropertyInfo info, string contorlValue,T t)
    {
        string temp = string.Empty;
        switch (info.PropertyType.ToString())
        {

            case "System.Byte":
                info.SetValue(t, Convert.ToByte(contorlValue), null); break;
            case "System.Int32":
                if (string.IsNullOrEmpty(contorlValue)) { temp = "0"; }
                else { temp = contorlValue; }
                info.SetValue(t, CommonMethod.ConvertToInt(temp, 0), null);
                break;
            case "System.Double":
                info.SetValue(t, Double.Parse(contorlValue), null);
                break;
            default:
                info.SetValue(t, (object)(contorlValue), null);
                break;
        }
    }

    /// <summary>
    /// 下拉列表控件数据绑定，默认值为指定的
    /// </summary>
    /// <param name="lc">列表控件</param>
    /// <param name="dt">数据表</param>
    /// <param name="colText">文本列名</param>
    /// <param name="colValue">值列名</param>
    /// <param name="HeaderValue">默认值</param>
    public static void ListControlDataBind(ListControl lc, DataTable dt, string colText, string colValue, string HeaderValue)
    {
        lc.Items.Clear();
        lc.Items.Insert(0, new ListItem(HeaderValue, ""));
        if (dt == null || dt.Rows.Count == 0) return;

        foreach (DataRow myRow in dt.Rows)
        {
            lc.Items.Add(new ListItem(myRow[colText].ToString(), myRow[colValue].ToString()));
        }
    }

    /// <summary>
    /// 下拉列表控件数据绑定，默认值为请选择
    /// </summary>
    /// <param name="lc">列表控件</param>
    /// <param name="dt">数据表</param>
    /// <param name="colText">文本列名</param>
    /// <param name="colValue">值列名</param>
    public static void ListControlDataBind(ListControl lc, DataTable dt, string colText, string colValue)
    {
        lc.Items.Clear();
        lc.Items.Insert(0, new ListItem("请选择", ""));
        if (dt == null || dt.Rows.Count == 0) return;

        foreach (DataRow myRow in dt.Rows)
        {
            lc.Items.Add(new ListItem(myRow[colText].ToString(), myRow[colValue].ToString()));
        }
       

    }

     
}