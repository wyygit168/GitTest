using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Service;
using System.Text;

public partial class admin_systemset_baseinfoset :SystemMainBasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadCssAndScript();
            AjaxHelper ajaxEntity = new AjaxHelper();  
            ajaxEntity.Action = SystemData.BaseInfo_SelectLoginTitle;
            ajaxEntity.PageStatus = "1";
            SystemSet sset = new SystemSet(ajaxEntity.PageStatus);
            txtlogintitle.Value= sset.SelectLoginTitle(ajaxEntity);
            
            ajaxEntity.Action = SystemData.BaseInfo_SelectWebTitle;
            txtwebtitle.Value = sset.SelectWebTitle(ajaxEntity);
        }
    }

    #region 加载Css、Js文件
    /// <summary>
    /// 加载Css、Js文件
    /// </summary>
    private void LoadCssAndScript()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("<link href=\"{0}\" rel=\"stylesheet\" type=\"text/css\" />", CurrentDomainRootPath + "style/admin/one/systemset/baseinfoset.aspx.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<link href=\"{0}\" rel=\"stylesheet\" type=\"text/css\" >", CurrentDomainRootPath + "style/common.css?v=" + CommonMethod.Version);
        litCss.Text = sb.ToString();
        sb = new StringBuilder();
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/admin/systemset/dataset.js?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/admin/systemset/baseinfoset.aspx.js?v=" + CommonMethod.Version);
        litScript.Text = sb.ToString();
    }
    #endregion

}