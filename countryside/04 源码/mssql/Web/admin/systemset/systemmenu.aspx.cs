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
public partial class admin_systemset_systemmenu : SystemMainBasePage
{

    #region Page_Load
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            if (CurrentCustomerID == 0)
            {
                #region 判断是否有新增 删除权限
                string url = SystemData.DetailForMenu;
                GetNewAndDelPurview(url, this.btnAdd, this.btnBatchDel);
                #endregion
                UtilitySearch.LoadTopMenuID(this.ddlTopMenuID);
                LoadScript();
                DisplayData();
            }
           else
           {
               divbtn.Style.Value = "display:none;";
               divTable.Visible = false;
               this.btnAdd.Visible = false;
               this.btnBatchDel.Visible = false;
               DisplayDataForCustomer();
           }
        }
    }
    #endregion

    #region 显示表格数据
    /// <summary>
    /// 显示表格数据
    /// </summary>
    private void DisplayData()
    {
        AjaxHelper ajaxEntity = new AjaxHelper();
        ajaxEntity.PageIndex = CommonMethod.ConvertToInt(txtPageIndex.Text, 0);
        ajaxEntity.Title = CommonMethod.ClearInputText(txtTitle.Text, 50);
        ajaxEntity.Status = ddlStatus.SelectedValue;
        ajaxEntity.Extend1 = CommonMethod.ClearInputText(txtMenuUrl.Text, 50);   
        ajaxEntity.Extend4 = ddlTopMenuID.SelectedValue;
        ajaxEntity.Extend3 = ddlOneMenu.SelectedValue;
        ajaxEntity.Action = SystemData.SystemMenu;
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

    #region 显示客户表格数据
    /// <summary>
    /// 显示客户表格数据
    /// </summary>
    private void DisplayDataForCustomer()
    {
        string strSql = " select AutoID,Title,MenuUrl,OrderValue,IsTopMenu,TopMenuID,ParentId,Status from systemmenu  where status <> 2 and IsSuperAdmin=0 order by OrderValue desc,AutoID asc  ";
        DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
        string strContent = "";
        int recordCount = 0;
        if (dt != null && dt.Rows.Count > 0)
        {
            recordCount = dt.Rows.Count;
            strContent = CreateTreeTable(dt);
        } 
        string strPage = DataHelper.SetPagination(100, recordCount, 0); 
        this.divContent.InnerHtml = strContent;
        this.divPageBar.InnerHtml = strPage; 
       
    }
     /// <summary>
    /// 拼接TreeTable
    /// </summary>
    public string CreateTreeTable(DataTable dt)
    {
        StringBuilder sb = new StringBuilder();
        if (dt != null && dt.Rows.Count > 0)
        {

            sb.Append(@"<table class='showList' id='tbList' >
                     <colgroup>
                            <col width='265px'/>
                            <col />
                            <col width='80px'/>
                            <col width='80px'/>
                    </colgroup>
                     <tr>
                            <td class='head'>资源名称</td>
                            <td class='head'>资源URL</td>
                            <td class='head'>排序值</td>
                            <td class='head'>状态</td>
                           
                    </tr>");

            DataRow[] arrDr1 = dt.Select("IsTopMenu=1");//顶级菜单
            foreach (DataRow dr1 in arrDr1)
            {
                //一级菜单
                DataRow[] arrDr2 = dt.Select("TopMenuID=" + dr1["AutoID"].ToString() + "AND ParentId=0");
                sb.Append(GetTableHtml(dr1, 0));
                foreach (DataRow dr2 in arrDr2)
                {

                    DataRow[] arrDr = dt.Select("TopMenuID=" + dr1["AutoID"].ToString() + "AND ParentId=" + dr2["AutoID"].ToString());
                    sb.Append(GetTableHtml(dr2, 1)); foreach (DataRow dr in arrDr)
                    {
                        sb.Append(GetTableHtml(dr, 2));
                    }
                }
            }
            sb.Append("</table><script type='text/javascript'>rowOutAndOver('tbList');</script>");
        }
        return sb.ToString();
    }

    /// <summary>
    /// TreeTable 拼装tr td
    /// </summary>
    /// <param name="dr"></param>
    /// <param name="resourceUrlType"></param>
    /// <returns></returns>
    private string GetTableHtml(DataRow dr, int resourceUrlType)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("<tr>");
        if (resourceUrlType == 0) { sb.AppendFormat("<td  >{0}</td> ", dr["Title"]); sb.Append("<td  >顶级菜单</td> "); }
        else if (resourceUrlType == 1) { sb.AppendFormat("<td  >{0}</td> ", "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + dr["Title"]); sb.Append("<td  >一级菜单</td> "); }
        else { sb.AppendFormat("<td  >{0}</td> ", "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + dr["Title"]); sb.AppendFormat("<td  >{0}</td> ", dr["MenuUrl"]); }
        sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["Ordervalue"]);
        sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", CommonMethod.ConvertToStatus(dr["Status"].ToString()));
        return sb.ToString();
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
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/admin/systemset/systemmenu.aspx.js?v=" + CommonMethod.Version);
        litScript.Text = sb.ToString();
    }
    #endregion

    
}
