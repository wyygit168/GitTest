using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Data;
using BusinessEntity;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

/// <summary>
///系统父类
/// </summary>
public class SystemBasePage:CommonPage
{
    protected override void OnInit(EventArgs e)
    {
        if (CurrentUser == null)
        {
            if (PageStatus == "1")
            {
                System.Web.HttpContext.Current.Response.Redirect("~/Login.aspx?backurl=" + CurrentWebPath);
            }
            else if (PageStatus == "2")
            {
                ClosePopPage();
            }
        } 
    }

    #region 页面类型 =1：基础页面， =2 弹出页面
    private string  pagestatus="";
    /// <summary>
    /// 页面类型 =1：基础页面， =2 弹出页面
    /// </summary>
    public string PageStatus
    {
        get
        {
            return pagestatus;
        }
        set
        {
            pagestatus = value;
        }
    }
    #endregion

    #region 当前用户实体
    /// <summary>
    /// 当前用户实体
    /// </summary>
    public systemuserEntity CurrentUser
    {
        get
        {
            systemuserEntity objEntity = Session["systemusers"] as systemuserEntity;
            if (objEntity == null)
            {
                if (PageStatus == "1")
                {
                    System.Web.HttpContext.Current.Response.Redirect("~/Login.aspx?backurl=" + CurrentWebPath);

                }
                else if (PageStatus == "2")
                {
                    System.Web.HttpContext.Current.Response.Redirect("~/Login.aspx");
                }
            }
            return objEntity;
        }
        set { Session["systemUsers"] = value; }
    }
    #endregion

    #region 当前用户AutoID
    /// <summary>
    /// 当前用户AutoID
    /// </summary>
    public int CurrentUserID
    {
        get { return CurrentUser.AutoID; }
    }
    #endregion

    #region 当前客户AutoID
    /// <summary>
    /// 当前客户AutoID
    /// </summary>
    public int CurrentCustomerID
    {
        get { return CurrentUser.CustomerID; }
    }
    #endregion

    #region 当前客户角色ID
    /// <summary>
    /// 当前客户角色ID
    /// </summary>
    public int CurrentRoleID
    {
        get { return CurrentUser.RoleID; }
    }
    #endregion
    
    #region 页面布局查询 Datatable

    private DataTable _LayOutTalble = null;

    public DataTable LayOutTable
    {
        get
        {
            if (_LayOutTalble == null)
            {
                _LayOutTalble = GetPurviewCacheDataTable();
            }
            return _LayOutTalble;
        }
    }

    #endregion

    #region 模块菜单权限操作

    #region 获取模块菜单权限数据集合，先读缓存文件

    /// <summary>
    /// 获取权限数据集合，先读缓存文件
    /// </summary>
    /// <returns></returns>
    public DataTable GetPurviewCacheDataTable()
    {
        DataTable dt =null;
        dt = CacheHelper.Instance.GetData(CacheDTName) as DataTable;
        if (dt == null)
        {
            string purviewcahce = CommonMethod.GetConfigValueByKey("DTC");
            string dtJson = OperateTxt.ReadPurviewFile(CurrentCustomerID, CurrentRoleID, purviewcahce);
            string decdtJson = "";
            if (dtJson.Length > 0)
            {
                decdtJson = DESEncrypt.Decrypt(dtJson);
            }
            DataSet ds = JsonHelper.Deserialize<DataSet>(decdtJson);
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                CacheHelper.Instance.Add(CacheDTName, dt);
            }
            else
            {
              ds = UtilitySearch.GetMenuByRoleId(CurrentRoleID);
                if (ds != null && ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                    dtJson = JsonHelper.JsonFromDataTable(dt);
                    string enctJson = DESEncrypt.Encrypt(dtJson); //加密
                    string purviwecache = CommonMethod.GetConfigValueByKey("DTC");
                    OperateTxt.WritePurviewFile(enctJson, CurrentCustomerID, CurrentRoleID, purviwecache);
                    CacheHelper.Instance.Add(CacheDTName, dt);
                }
            }
        }
        return dt;
    }

    #endregion

    #region 根据url，获取权限值
    /// <summary>
    /// 根据url，获取权限值
    /// </summary>
    public string GetPurviewForUrl(string url, string purviewtype)
    {
        string returnvalue = "0";
        if (LayOutTable != null && LayOutTable.Rows.Count > 0)
        {
            string strFormat = string.Format(" RoleID='{0}'  and MenuUrl='{1}'  ", CurrentRoleID, url);
            DataRow[] dr = LayOutTable.Select(strFormat);
            if (dr != null && dr.Length > 0)
            {
                if (dr[0]["IsPurview"].ToString().Equals("1"))
                {
                    if (dr[0]["MenuType"].ToString().Equals("1"))
                    {
                        switch (purviewtype.ToLower())
                        {
                            case "new": returnvalue = dr[0]["IsAdd"].ToString(); break;
                            case "view": returnvalue = dr[0]["IsView"].ToString(); break;
                            case "edit": returnvalue = dr[0]["IsEdit"].ToString(); break;
                            case "delete": returnvalue = dr[0]["IsDelete"].ToString(); break;
                        }
                    }
                    else
                    {
                        returnvalue = "1";
                    }
                }
            }

        }
        return returnvalue;
    }
    #endregion

    #endregion

    #region Cookie属性
    public string CT
    {
        get
        {
            string ct = "";
            ct = CommonMethod.GetConfigValueByKey("CT");
            return ct;
        }
    }
    public string CN
    {
        get
        {
            string ct = "";
            ct = CommonMethod.GetConfigValueByKey("CN");
            return ct;
        }
    }
    public string CW
    {
        get
        {
            string ct = "";
            ct = CommonMethod.GetConfigValueByKey("CW");
            return ct;
        }
    }
    public string CC
    {
        get
        {
            string ct = "";
            ct = CommonMethod.GetConfigValueByKey("CC");
            return ct;
        }
    }
    public string CE
    {
        get
        {
            string ct = "";
            ct = CommonMethod.GetConfigValueByKey("CE");
            return ct;
        }
    }
    #endregion

    #region 读取菜单模块权限缓存名称（权限名+角色名）
    /// <summary>
    /// 读取权限缓存名称（权限名+角色名）
    /// </summary>
    public string CacheDTName
    {
        get
        {
            string ct = "";
            ct = CommonMethod.GetConfigValueByKey("DTC")+"_"+CurrentRoleID;
            return ct;
        }
    }
    #endregion

    #region 读取登录名称配置
    /// <summary>
    /// 读取登陆名称配置
    /// </summary>
    public string ConfigLoginTitle
    {
        get
        {
            string ct = "";
            ct = CommonMethod.GetConfigValueByKey("LoginTitle");
            return ct;
        }
    }
    #endregion

    #region 读取网站名称配置
    /// <summary>
    /// 读取网站名称配置
    /// </summary>
    public string ConfigWebTitle
    {
        get
        {
            string ct = "";
            ct = CommonMethod.GetConfigValueByKey("WebTitle");
            return ct;
        }
    }
    #endregion

    #region CacheUrl 参数
    /// <summary>
    /// CacheUrl 参数
    /// </summary>
    public string CacheUrl
    {
        get
        {
            string action = "";
            if (Request.QueryString["iscache"] != null)
            {
                action = Request.QueryString["iscache"].Trim().ToLower();
            }
            return action;
        }
    }
    #endregion

    #region 获取系统登录名称
    /// <summary>
    /// 获取系统登录名称
    /// </summary>
    public string LoginTitle
    {
        get
        {
            string logintitle = CacheHelper.Instance.GetData(ConfigLoginTitle) as string;
            if (string.IsNullOrEmpty(logintitle))
            {
                OperateXml xml = new OperateXml();
                logintitle = xml.SelectbaseconfigFile(CurrentCustomerID.ToString(), "logintitle");
                CacheHelper.Instance.Add(ConfigLoginTitle, logintitle);
            }
            return logintitle;
        }
    }

    #endregion
}