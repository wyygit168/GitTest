using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

/// <summary>
///OperateXml 的摘要说明
/// </summary>
public class OperateXml
{
    private XmlDocument xmlDoc;

    #region 配置文件信息xml文件操作

    #region 获取配置文件路径
    /// <summary>
    /// 获取配置文件路径
    /// </summary>
    /// <returns></returns>
    public string GetbaseconfigFilePath()
    {
        HttpServerUtility hsu = HttpContext.Current.Server;
        string strpath = "/config/baseconfig/baseinfo.xml";

        string physicspath = hsu.MapPath("~") + strpath;
        return physicspath;
    }
    #endregion

    #region 保存配置文件信息
    /// <summary>
    /// 保存配置文件信息
    /// </summary>
    public void SaveXmlPath()
    {
        string physicspath = GetbaseconfigFilePath();
        xmlDoc.Save(physicspath);//保存 
    }
    #endregion

    #region  加载基础配置文件
    /// <summary>
    /// 加载基础配置xml文件
    /// </summary>
    private void LoadbaseconfigXml()
    {
        xmlDoc = new XmlDocument();
        string physicspath = GetbaseconfigFilePath();
        xmlDoc.Load(physicspath);
    }
    #endregion

    #region 根据customerid 添加基础配置信息
    /// <summary>
    /// 根据customerid 添加基础配置信息
    /// </summary>
    /// <param name="customerid">客户id</param>
    /// <param name="key">key值</param>
    /// <param name="value">value值</param>
    public void AddbaseconfigFile(string customerid, string key,string value)
    {
        LoadbaseconfigXml();
        bool isOneNode = true;
        bool isTwoNode = true;
        XmlNode customers = xmlDoc.SelectSingleNode("Settings");
        XmlNodeList nodeList = customers.ChildNodes;//获取Settings节点的所有子节点 
        foreach (XmlNode xn in nodeList)//遍历所有子节点 
        {
            XmlElement xe = (XmlElement)xn;//将子节点类型转换为XmlElement类型 
            if (xe.GetAttribute("id").Equals(customerid))
            {
                isOneNode = false;  
                XmlNodeList nls = xe.ChildNodes;//继续获取xe子节点的所有子节点 
                foreach (XmlNode xn1 in nls)//遍历 
                {
                    XmlElement xe2 = (XmlElement)xn1;//转换类型 
                    if (xe2.Name.Equals(key))//如果找到 
                    {
                        isTwoNode = false;
                        xe2.SetAttribute("value", value);
                        break;
                    }
                }
                if (isTwoNode)
                {
                    XmlElement eleKey = xmlDoc.CreateElement(key);
                    eleKey.SetAttribute("value", value);
                    xe.InsertBefore(eleKey, xe.FirstChild);
                }
                break;
            }
        }
        if (isOneNode)
        {
            XmlElement customer = xmlDoc.CreateElement("customer");
            customer.SetAttribute("id", customerid);
            XmlElement eleKey = xmlDoc.CreateElement(key);
            eleKey.SetAttribute("value", value);
            customer.AppendChild(eleKey);
            customers.InsertBefore(customer, customers.FirstChild);
        }
        SaveXmlPath();
    }
    #endregion

    #region 根据customerid 查找基础配置文件信息
    /// <summary>
    /// 根据customerid 查找基础配置文件信息
    /// </summary>
    /// <param name="customerid">客户id</param>
    /// <param name="key">key值</param>
    /// <param name="value">value值</param>
    public string  SelectbaseconfigFile(string customerid, string key)
    {
       string returnValue="";
        LoadbaseconfigXml();
        XmlNodeList nodeList = xmlDoc.SelectSingleNode("Settings").ChildNodes;//获取Settings节点的所有子节点 
        foreach (XmlNode xn in nodeList)//遍历所有子节点 
        {
            XmlElement xe = (XmlElement)xn;//将子节点类型转换为XmlElement类型 
            if (xe.GetAttribute("id").Equals(customerid))
            {
                //如果下面有子节点在下走 
                XmlNodeList nls = xe.ChildNodes;//继续获取xe子节点的所有子节点 
                foreach (XmlNode xn1 in nls)//遍历 
                {
                    XmlElement xe2 = (XmlElement)xn1;//转换类型 
                    if (xe2.Name.Equals(key))//如果找到 
                    {
                        returnValue=xe2.GetAttribute("value");
                        break;
                    }
                }
            }
        }
        return returnValue;
    }
    #endregion

    #region  根据customerid 更新基础配置文件
    /// <summary>
    /// 根据customerid 更新基础配置文件
    /// </summary>
    /// <param name="customerid">客户id</param>
    /// <param name="key">key值</param>
    /// <param name="value">value值</param>
    public void UpdatebaseconfigFile(string customerid,string key,string value)
    {
        LoadbaseconfigXml();
        XmlNodeList nodeList = xmlDoc.SelectSingleNode("Settings").ChildNodes;//获取Settings节点的所有子节点 
        foreach (XmlNode xn in nodeList)//遍历所有子节点 
        {
            XmlElement xe = (XmlElement)xn;//将子节点类型转换为XmlElement类型 
            if (xe.GetAttribute("id").Equals(customerid))
            {
                //如果下面有子节点在下走 
                XmlNodeList nls = xe.ChildNodes;//继续获取xe子节点的所有子节点 
                foreach (XmlNode xn1 in nls)//遍历 
                {
                    XmlElement xe2 = (XmlElement)xn1;//转换类型 
                    if (xe2.Name.Equals(key))//如果找到 
                    {
                        xe2.SetAttribute("value", value);
                        break;

                    }
                }
            }
        }
        SaveXmlPath();
    }
    #endregion

    #region 删除customerid 下的所有配置文件
    /// <summary>
    /// 删除customerid 下的所有配置文件
    /// </summary>
    /// <param name="customerid">客户id</param> 
    public void DeletebaseconfigFileForCustomeid(string customerid)
    {

        LoadbaseconfigXml();
        XmlNode node = xmlDoc.SelectSingleNode("Settings");//获取Settings节点的所有子节点 
        XmlNodeList nodeList=node.ChildNodes;
        foreach (XmlNode xn in nodeList)
        {
            XmlElement xe = (XmlElement)xn; 
            if (xe.GetAttribute("id").Equals(customerid))
            {
                node.RemoveChild(xn);
            } 
        }
        SaveXmlPath();
    }

    #endregion

    #region 删除customerid 下 为key 值的所有配置文件
    /// <summary>
    /// 删除customerid 下 为key 值的所有配置文件
    /// </summary>
    /// <param name="customerid">客户id</param>
    /// <param name="key">key值</param>
    public void DeletebaseconfigFileForKey(string customerid,string key)
    {

        LoadbaseconfigXml();
        XmlNodeList nodeList = xmlDoc.SelectSingleNode("Settings").ChildNodes;//获取Settings节点的所有子节点 
        foreach (XmlNode xn in nodeList)
        {
            XmlElement xe = (XmlElement)xn;
            if (xe.GetAttribute("id").Equals(customerid))
            {
                XmlNodeList nls = xe.ChildNodes;//继续获取xe子节点的所有子节点 
                foreach (XmlNode xn1 in nls)//遍历 
                {
                    XmlElement xe2 = (XmlElement)xn1;//转换类型 
                    if (xe2.Name.Equals(key))//如果找到 
                    {
                        xn.RemoveChild(xn1);
                    }
                }
            }
        }
        SaveXmlPath();
    }

    #endregion

    #endregion

}