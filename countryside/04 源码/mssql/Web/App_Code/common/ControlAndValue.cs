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
    /// ͨ��������ƺͷ������ÿؼ���ֵ
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
                    // ��ȡ���Ӧ�ı���
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
    /// ͨ��������ƺͷ��ʹӿؼ��л�ȡ�ؼ���ֵ��Ȼ������ݶ�����и�ֵ
    /// </summary>
    /// <param name="parentControl"></param>
    public static void SetValues4Controls<T>(Control parentControl, T t)
    {
        Type type = t.GetType();
        foreach (Control var in parentControl.Controls)
        {
            if (var.ID != null && var.ID.Contains("txt"))//TextBox�ؼ���ȡֵ
            {
                TextBox box = var as TextBox;
                if (box != null)
                {
                    string propertyName = var.ID.Substring(3);// ��ȡ���Ӧ�ı���
                    PropertyInfo info = type.GetProperty(propertyName);
                    if (info != null)
                    { 
                        SetValueToPropertyInfo(info, box.Text, t);
                    }
                }
            }
            else  if (var.ID != null && var.ID.Contains("ddl")) //�����б��ȡֵ
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
    /// �����б�ؼ����ݰ󶨣�Ĭ��ֵΪָ����
    /// </summary>
    /// <param name="lc">�б�ؼ�</param>
    /// <param name="dt">���ݱ�</param>
    /// <param name="colText">�ı�����</param>
    /// <param name="colValue">ֵ����</param>
    /// <param name="HeaderValue">Ĭ��ֵ</param>
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
    /// �����б�ؼ����ݰ󶨣�Ĭ��ֵΪ��ѡ��
    /// </summary>
    /// <param name="lc">�б�ؼ�</param>
    /// <param name="dt">���ݱ�</param>
    /// <param name="colText">�ı�����</param>
    /// <param name="colValue">ֵ����</param>
    public static void ListControlDataBind(ListControl lc, DataTable dt, string colText, string colValue)
    {
        lc.Items.Clear();
        lc.Items.Insert(0, new ListItem("��ѡ��", ""));
        if (dt == null || dt.Rows.Count == 0) return;

        foreach (DataRow myRow in dt.Rows)
        {
            lc.Items.Add(new ListItem(myRow[colText].ToString(), myRow[colValue].ToString()));
        }
       

    }

     
}