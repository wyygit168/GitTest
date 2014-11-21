using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessEntity;
using System.Text;

public partial class login : CommonPage
{
    private string BACK_URL = "";

    #region Cookie属性
    public string CT
    {
        get
        {
            string ct = "";
            ct=CommonMethod.GetConfigValueByKey("CT");
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

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dtUrl = GetDatablePriviewForUrl();
            if (dtUrl != null && dtUrl.Rows.Count > 0)
            {
                string customerid = dtUrl.Rows[0]["CustomerID"].ToString();
                OperateXml xml = new OperateXml();
                string logintitle = xml.SelectbaseconfigFile(customerid, "logintitle");
                litLoginTitle.Text = logintitle + "-登录";
                loginTopText.InnerHtml = logintitle;
            }
            LoadCssAndScript();
            HttpCookie cookie = Request.Cookies[CT];
            if (cookie != null)
            {
                if (cookie[CC] != null)
                {
                    string userAccount = CommonMethod.ClearInputText(DESEncrypt.Decrypt(cookie[CN]));
                    string password = CommonMethod.ClearInputText(DESEncrypt.Decrypt(cookie[CW]));
                    txtName.Text = HttpUtility.UrlDecode(userAccount, Encoding.Default);
                    password = HttpUtility.UrlDecode(password, Encoding.Default);
                    txtPassword.Attributes.Add("value", password);
                    ddlCookSave.SelectedValue = cookie[CC];
                }
                else
                {
                    cookie.Expires = DateTime.Now.AddHours(-1);
                    Response.Cookies.Add(cookie);
                }
            }
        }
    }

    /// <summary>
    ///  CT:系统登录Cookie名称:例如 usercookie
    ///  CC:cookie 有限期名称
    ///  CN:cookie 用户名名称
    ///  CW:cookie 密码名称
    ///  CE:cookie 角色名称
    /// </summary> 
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        DataTable dtUrl = GetDatablePriviewForUrl();
        if (dtUrl != null && dtUrl.Rows.Count > 0)
        {
             #region 验证
            CommonMethod cm = new CommonMethod();
            if (txtName.Text.Trim().Length == 0)
            {
                AlertError("用户名或密码不可以为空！");
                Select(txtName);
            }
            if (txtPassword.Text.Trim().Length == 0)
            {
                AlertError("用户名或密码不可以为空！");
                Select(txtPassword);
            }
            #endregion
  
            string customerid = dtUrl.Rows[0]["CustomerID"].ToString();
            int provinceid = dtUrl.Rows[0]["ProvinceID"].ToInt(0);
            int cityid = dtUrl.Rows[0]["CityID"].ToInt(0);
            int countyid = dtUrl.Rows[0]["CountyID"].ToInt(0);
            int townid = dtUrl.Rows[0]["TownID"].ToInt(0);
            string pwd = DESEncrypt.Encrypt(CommonMethod.ClearInputText(txtPassword.Text));
            systemuserEntity objEntity = UtilitySearch.GetSystemUserByUserNameAndPwd(CommonMethod.ClearInputText(txtName.Text), pwd,customerid);
            if (objEntity != null)
            {
                string defaultUrl = "";
                DataTable dt = new DataTable();
                DataSet ds = UtilitySearch.GetMenuByUserId(objEntity.AutoID);
                if (ds != null && ds.Tables.Count > 0) dt = ds.Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    #region 保存Cookie和Session
                    objEntity.RoleID = dt.Rows[0]["RoleID"].ToInt(0);
                    objEntity.ProvinceID = provinceid;
                    objEntity.CityID = cityid;
                    objEntity.CountyID = countyid;
                    objEntity.TownID = townid;
                    Session["systemusers"] = objEntity;
                    HttpCookie cookie = Request.Cookies[CT]; //系统登录Cookie名称:例如 usercookie
                    bool isEditCookie = true;
                    if (cookie != null)
                    {
                        string cstrCookSave = cookie[CC]; //cookie 有限期名称
                        string userAccount = CommonMethod.ClearInputText(DESEncrypt.Decrypt(cookie[CN]));//cookie用户名名称
                        string password = CommonMethod.ClearInputText(DESEncrypt.Decrypt(cookie[CW])); // cookie 密码名称
                        userAccount = HttpUtility.UrlDecode(userAccount, Encoding.Default);
                        password = HttpUtility.UrlDecode(password, Encoding.Default);
                        if (userAccount != objEntity.Title || cookie[CW] != objEntity.UserPassword)
                        {
                            isEditCookie = true;
                        }
                        else if (cstrCookSave == ddlCookSave.SelectedValue)
                        {
                            isEditCookie = false; //Cookie存在，并且没有更改
                        }
                    }
                    if (isEditCookie && !ddlCookSave.SelectedValue.Equals("0")) //Cookie存在，并且更改Cookie
                    {
                        cookie = new HttpCookie(CT);
                        string name = DESEncrypt.Encrypt(CommonMethod.ClearInputText(objEntity.Title));
                        cookie[CN] = HttpUtility.UrlEncode(name, Encoding.Default);
                        cookie[CW] = HttpUtility.UrlEncode(objEntity.UserPassword, Encoding.Default);
                        DateTime expiresTime = DateTime.Now;
                        switch (ddlCookSave.SelectedValue)
                        {
                            case "1": expiresTime = DateTime.Now.AddDays(1); break;
                            case "2": expiresTime = DateTime.Now.AddDays(7); break;
                            case "3": expiresTime = DateTime.Now.AddMonths(1); break;
                        }
                        cookie[CC] = ddlCookSave.SelectedValue;
                        cookie[CE] = objEntity.RoleID.ToString();
                        cookie.Expires = expiresTime;
                        Response.Cookies.Add(cookie);
                    }
                    else if (cookie != null && ddlCookSave.SelectedValue.Equals("0"))//不保存Cookie，cookie失效
                    {
                        cookie.Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies.Add(cookie);
                    }
                    #endregion
                    defaultUrl = dt.Rows[0]["MenuUrl"].ToString();
                    BACK_URL = string.IsNullOrEmpty(Request.QueryString["backurl"]) ? defaultUrl : Server.HtmlDecode(Request.QueryString["backurl"]);
                    Response.Redirect(BACK_URL);
                }
                else
                {
                    clearData();
                    AlertError("对不起，你没有权限登录，请和管理员联系！");
                }
            }
            else
            {
                clearData();
                AlertError("密码或用户名不正确！");
            }
        }
        else
        {
            clearData();
            AlertError("对不起，你没有权限登录，请和管理员联系！");
        }
    }

    #region 清空数据操作
    /// <summary>
    /// 清空数据操作
    /// </summary>
    private void clearData()
    {
        HttpCookie cookie = Request.Cookies[CT];
        if (cookie != null)
        {
            cookie.Expires = DateTime.Now.AddHours(-1);
            Response.Cookies.Add(cookie);
        }
        txtPassword.Attributes.Add("value", "");
        
    }
    #endregion

    #region 加载Css、Js文件
    /// <summary>
    /// 加载Css、Js文件
    /// </summary>
    private void LoadCssAndScript()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("<link href=\"{0}\" rel=\"stylesheet\" type=\"text/css\" />", CurrentDomainRootPath + "scripts/ymPrompt/skin/black/ymPrompt.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<link href=\"{0}\" rel=\"stylesheet\" type=\"text/css\" />", CurrentDomainRootPath + "style/admin/one/login.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/ymPrompt/ymPrompt.js?v=" + CommonMethod.Version);
        litCss.Text = sb.ToString();
        sb = new StringBuilder();
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/admin/login.js?v=" + CommonMethod.Version);
        litScript.Text = sb.ToString();
    }
    
    #endregion
     

    
}