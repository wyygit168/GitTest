using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using PersistenceLayer;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // Response.Write(AjaxAction.web_register.ToString());


        DataTable dt = CacheHelper.Instance.GetData("testtabke") as DataTable;


        myTest obj = new myTest();
        obj.Address = "江苏苏州";
        obj.Name = "陶钟";
        obj.Age = 23;
        string mytestjson = JsonHelper.ObjectToJson<myTest>(obj);
        myTest objentity = JsonHelper.JsonToObject<myTest>(mytestjson);

        string s1 = JsonHelper.SerializeObject(obj);
        myTest o1 = JsonHelper.Deserialize<myTest>(s1);



        string strsql = "select * from systemmenu";
        DataTable dtt = Query.ProcessSql(strsql, DataHelper.DataBase);
        string teststr=JsonHelper.JsonFromDataTable(dtt);

        DataSet dtst = Query.ProcessMultiSql(strsql, DataHelper.DataBase);
         string strr = JsonHelper.ObjectToJson<DataSet>(dtst);
        DataSet dset = JsonHelper.JsonToObject<DataSet>(strr);


        //DataSet ddd = JsonHelper.Deserialize<DataSet>(teststr);
        //string filepath = OperateTxt.GetPurviewFilePath("1","1");
         //OperateTxt.WritePurviewFile(teststr, 1, 1);
         //string xxx = OperateTxt.ReadPurviewFile(1, 1);
         //DataTable ddd = JsonHelper.Deserialize<DataSet>(xxx).Tables[0];

        //DataTable d11t= GetPurviewCacheDataTable();
        //GridView1.DataSource = d11t;
        //GridView1.DataBind();


        //DataRow[] drMenuArray = d11t.Select("  IsPurview='1' and IsShowMenu='1'  and MenuType='0'  and ParentId='2' and AutoID='7' ", "OrderValue asc");
        //DataRow[] drMenuArray = d11t.Select(" AutoID='7' ");

        //GridView2.DataSource =drMenuArray[0][0];
        //GridView2.DataBind();

    }


    public class myTest
    {
        //private string strName = "";
        //private int iAge;
        //private string strAddress="";

        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        
    }


    public DataTable GetPurviewCacheDataTable()
    {
        DataTable dt = null;
        dt = CacheHelper.Instance.GetData("purview_1") as DataTable;
        if (dt == null)
        {
            string dtJson = OperateTxt.ReadPurviewFile(0, 1,"py");
            //string decdtJson = "";
            //if (dtJson.Length > 0)
            //{
            //    decdtJson = DESEncrypt.Decrypt(dtJson);
            //}
            DataSet ds = JsonHelper.Deserialize<DataSet>(dtJson);
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                CacheHelper.Instance.Add("purview_1", dt);
            }
            else
            {
                ds = UtilitySearch.GetMenuByRoleId(1);
                if (ds != null && ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                    dtJson = JsonHelper.JsonFromDataTable(dt);
                    //string enctJson = DESEncrypt.Encrypt(dtJson); //加密
                    //OperateTxt.WritePurviewFile(dtJson, 0, 1,"pu");
                   //CacheHelper.Instance.Add("purview_1", dt,"pu");
                }
            }
        }
        return dt;
    }
}