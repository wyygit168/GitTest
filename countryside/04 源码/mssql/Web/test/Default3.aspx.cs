using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class test_Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["action"] != null)
        {
            GetJsonString();
        }
    }

    public void GetJsonString()
    {
        DataTable dt = new DataTable("chart");
        DataColumn dc = new DataColumn("dcData");
        dt.Columns.Add(dc);
        string[] strData = new string[] { "1","2","3","4","5","6"};
        for (int i = 0; i < strData.Length; i++)
        {
            DataRow dr = dt.NewRow();
            dr[0] = strData[i];
            dt.Rows.Add(dr);
        }
        string strJson = JsonHelper.JsonFromDataTable(dt);
        CommonMethod.ResponseContent(strJson);
    }
}