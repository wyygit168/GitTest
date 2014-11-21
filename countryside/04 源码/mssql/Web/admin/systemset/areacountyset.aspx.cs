using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using BusinessEntity;
using PersistenceLayer;
using BLL.Service;
public partial class admin_systemset_areacountyset : SystemMainBasePage
{
    #region Page_Load
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            #region 判断是否有新增 删除权限
            string url = SystemData.DetailForCounty;
            GetNewAndDelPurview(url, this.btnAdd, this.btnBatchDel);
            #endregion
            LoadScript();
            DisplayData();
        }
    }
    #endregion

    #region 显示表格数据
    /// <summary>
    /// 显示表格数据
    /// </summary>
    private void DisplayData()
    {
        UtilitySearch.LoadProvince(this.drpProvince);
        AjaxHelper ajaxEntity = new AjaxHelper();
        ajaxEntity.PageIndex = CommonMethod.ConvertToInt(txtPageIndex.Text, 0);
        ajaxEntity.Title = CommonMethod.ClearInputText(txtTitle.Text, 50);
        ajaxEntity.Status = ddlStatus.SelectedValue;
        ajaxEntity.Extend1 = drpProvince.SelectedValue;
        ajaxEntity.Extend3 = drpCity.SelectedValue;
        ajaxEntity.Action = SystemData.AreaCounty;
        ajaxEntity.PageStatus = "1";
        SystemSet sset = new SystemSet(ajaxEntity.PageStatus);
        string strData = sset.GetHtmlString(ajaxEntity);
        string[] strDataArray = strData.Split(new string[] { "$$$$" }, StringSplitOptions.None);
        if (strDataArray != null && strDataArray.Length > 0)
        {
            this.divContent.InnerHtml = strDataArray[0];
            this.divPageBar.InnerHtml = strDataArray[1];
            this.txtPageIndex.Text = strDataArray[2];
        }
    }

    #endregion

    #region 加载Js文件
    /// <summary>
    /// 加载Js文件
    /// </summary>
    private void LoadScript()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/admin/systemset/dataset.js?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/admin/systemset/areacountyset.aspx.js?v=" + CommonMethod.Version);
        litScript.Text = sb.ToString();
    }
    #endregion 
}