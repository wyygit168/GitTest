using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register : WebBasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadCssAndScript();
            imgtop.Src = CurrentDomainRootPath + "images/web/register/group_key.gif";
            aindex.HRef = CurrentDomainRootPath + "index/";
            string checkcode = CurrentDomainRootPath + "ccode/0" ;
            imgVerify.Src = checkcode;
            //imgVerify.Attributes.Add("onclick", "this.src=this.src+?");
        }
    }

    #region 加载CSS Js文件
    /// <summary>
    ///  加载CSS Js文件
    /// </summary>
    private void LoadCssAndScript()
    {
        #region 顶部加载
        Head.Title = WebTitle + "-注册"; 
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("<link href=\"{0}\" rel=\"stylesheet\" type=\"text/css\" />", CurrentDomainRootPath + "scripts/ymPrompt/skin/black/ymPrompt.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/web/One/register.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/common.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/jquery-1.7.2.min.js?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/ymPrompt/ymPrompt.js?v=" + CommonMethod.Version);
        litTopCssAndScript.Text = sb.ToString();

        #endregion

        #region 底部加载

        sb = new StringBuilder();
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/common.js?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/web/register.js?v=" + CommonMethod.Version);
        litBottomScript.Text = sb.ToString();

        #endregion
    }
    #endregion 

      //if (string.IsNullOrEmpty(md5Sign) || !HttpContext.Current.Session["CheckCode"].ToString().ToLower().Equals(md5Sign.ToLower()))
      //      ResponseAjaxContent("2");
}