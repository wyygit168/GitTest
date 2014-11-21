using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using PersistenceLayer;
using BusinessEntity;
using System.Web.UI.WebControls;
using System.Text;
/// <summary>
///公共查询类
/// </summary>
public class UtilitySearch:System.Web.UI.Page
{

    #region 根据用户名和密码获取用户实体
    /// <summary>
    /// 根据用户名和密码获取用户实体
    /// </summary>
    /// <param name="userAccount">用户名</param>
    /// <param name="password">密码</param>
    /// <param name="customerid">客户id</param>
    /// <returns>成功返回CurrentUser Object，否则返回null</returns>
    public static systemuserEntity GetSystemUserByUserNameAndPwd(string userAccount, string password,string customerid)
    {
        RetrieveCriteria rc = new RetrieveCriteria(typeof(systemuserEntity));
        Condition c = rc.GetNewCondition();
        c.AddEqualTo(systemuserEntity.Columns.Title, userAccount);
        c.AddEqualTo(systemuserEntity.Columns.UserPassword, password);
        c.AddEqualTo(systemuserEntity.Columns.CustomerID, customerid);
        systemuserEntity objEntity = rc.AsEntity() as systemuserEntity;
        return objEntity;
 
    }
    #endregion

    #region 根据用户Id 获取菜单Url 角色ID
    /// <summary>
    /// 根据用户Id 获取菜单Url 角色ID
    /// </summary>
    /// <param name="userId"> 用户ID</param>
    /// <returns></returns>
    public static DataSet GetMenuByUserId(int userId)
    {
        string strSql = string.Format(@"select  Top 1    m.MenuUrl,r.AutoID RoleID 
                        from system_role_menu rm  with(nolock)
                        inner join systemrole r   with(nolock) on r.AutoID=rm.RoleID
                        inner join systemmenu m   with(nolock) on m.AutoID=rm.MenuID
                        inner join system_user_role ur   with(nolock) on ur.RoleID=r.AutoID
                        inner join systemuser u   with(nolock) on ur.UserID=u.AutoID
                        where u.AutoID={0} and r.Status=1 and m.Status=1 and u.Status=1  AND IsTopMenu=0 AND ParentId>0 AND IsPurview=1 AND IsShowMenu=1 
                        order by m.OrderValue desc,m.AutoID asc 
                         ", userId);
        DataSet ds = Query.ProcessMultiSql(strSql, DataHelper.DataBase);
        return ds;
    }
    #endregion

    #region 根据Rold 获取菜单内容
    /// <summary>
    /// 根据Rold 获取菜单内容
    /// </summary>
    /// <param name="roleid"> Rold</param>
    public static DataSet GetMenuByRoleId(int roleid)
    {
        string strSql = string.Format(@"select m.AutoID,m.Title, m.MenuUrl,m.TopMenuID,m.IsTopMenu,m.OrderValue,m.Alt,m.ParentId,m.MenuType,  rm.IsPurview,rm.IsShowMenu,rm.IsAdd,rm.IsView,rm.IsEdit,rm.IsDelete,r.AutoID RoleID
                                        from system_role_menu rm
                                        inner join systemrole r on r.AutoID=rm.RoleID
                                        inner join systemmenu m on m.AutoID=rm.MenuID
                                        where r.Status=1 and m.Status=1
                                        and rm.RoleID={0}
                                        order by m.OrderValue desc,m.AutoID asc  
                         ", roleid);
        DataSet ds = Query.ProcessMultiSql(strSql, DataHelper.DataBase);
        return ds;
    }
    #endregion

    #region 根据url 判断是否有登陆权限
    /// <summary>
    /// 根据url 判断是否有登陆权限,如果有权限，获取客户id，省 市 县等信息
    /// </summary>
    /// <param name="domain">登陆域名</param>
    /// <returns></returns>
    public static DataSet GetLoginPriviewForUrl(string domain)
    {
        string strSql = string.Format(@"  
              select cd.CustomerID,d.Title domaintitle,c.ProvinceID,c.CityID,c.CountyID,c.TownID from system_customer_domain cd
              inner join systemcustomer c on cd.CustomerID=c.AutoID
              inner join systemdomain d on cd.DomainID=d.AutoID
              where d.title='{0}' and c.status=1 and d.status=1 and c.openstatus=1 ", domain);
        return Query.ProcessMultiSql(strSql, DataHelper.DataBase);
    }
    #endregion

    #region 绑定顶级菜单下拉列表
    /// <summary>
    /// 绑定顶级菜单下拉列表
    /// </summary>
    public static void LoadTopMenuID(DropDownList drp)
    {
        string strSql = "select AutoID,Title from systemmenu  where status <> 2 and IsTopMenu=1   order by OrderValue desc,AutoID desc ";
        DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
        ControlAndValue.ListControlDataBind(drp, dt, "Title", "AutoID");
    }
    #endregion

    #region 绑定一级菜单菜单
    /// <summary>
    ///  绑定一级菜单菜单
    /// </summary>
    public static void LoadOneMenu(DropDownList drp, int topMenuID)
    {
        string strSql =string.Format("select  AutoID,Title  from systemmenu  where status <> 2 and parentId=0 and TopMenuID='{0}' order by OrderValue desc,AutoID desc  ",topMenuID);
        DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
        ControlAndValue.ListControlDataBind(drp, dt, "Title", "AutoID");
    }
    #endregion

    #region 绑定客户下拉列表
    /// <summary>
    /// 绑定客户下拉列表
    /// </summary>
    public static void LoadBindCustomer(DropDownList drp)
    {
        string strSql = "SELECT AutoID,Title FROM systemcustomer where status <> 2   order by OrderValue desc,AutoID desc ";
        DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
        ControlAndValue.ListControlDataBind(drp, dt, "Title", "AutoID");
    }

    /// <summary>
    /// 绑定客户下拉列表
    /// </summary>
    public static void LoadBindCustomer(DropDownList drp, int curid)
    {
        string strSql = string.Format("SELECT AutoID,Title FROM systemcustomer where AutoID='{0}' ", curid);
        DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
        ControlAndValue.ListControlDataBind(drp, dt, "Title", "AutoID");
    }
    #endregion

    #region 绑定域名下拉列表
    /// <summary>
    /// 绑定域名下拉列表
    /// </summary>
    public static void LoadBindDomain(DropDownList drp)
    {
        string strSql = "select AutoID,Title from systemdomain  where status =0  order by OrderValue desc,AutoID desc ";
        DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
        ControlAndValue.ListControlDataBind(drp, dt, "Title", "AutoID");
    }

    /// <summary>
    /// 绑定域名下拉列表，
    /// </summary>
    /// <param name="drp"></param>
    /// <param name="curid"></param>
    /// <param name="type"></param>
    public static void LoadBindDomain(DropDownList drp, int curid, string type)
    {
        string strSql = string.Format("select AutoID,Title from systemdomain  where status =0 or AutoID='{0}'  order by OrderValue desc,AutoID desc ", curid);
        if (type == "view")
        {
            strSql = string.Format("select AutoID,Title from systemdomain  where  AutoID='{0}' ", curid);
        }
        DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
        ControlAndValue.ListControlDataBind(drp, dt, "Title", "AutoID");
    }
    #endregion

    #region 绑定省、直辖市列表
    /// <summary>
    /// 绑定省、直辖市列表
    /// </summary>
    public static void LoadProvince(DropDownList drp)
    {
        string strSql = "select AutoID,Title from areaprovince  where status<>2  order by OrderValue desc,AutoID asc ";
        DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
        ControlAndValue.ListControlDataBind(drp, dt, "Title", "AutoID");
    }

    /// <summary>
    /// 绑定省、直辖市列表
    /// </summary>
    /// <param name="drp"></param>
    /// <param name="curid"></param>
    /// <param name="type"></param>
    public static void LoadProvince(DropDownList drp, int curid, string type,string headvalue)
    {
        string strSql = string.Format("select AutoID,Title from areaprovince  where (status<>2)  order by OrderValue desc,AutoID asc " );
        if (type == "view")
        {
            strSql = string.Format("select AutoID,Title from areaprovince  where  AutoID='{0}' ", curid);
        }
        DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
        ControlAndValue.ListControlDataBind(drp, dt, "Title", "AutoID",headvalue);
    }

    #endregion

    #region 绑定城市列表
    /// <summary>
    /// 绑定城市列表
    /// </summary>
    /// <param name="drp"></param>
    /// <param name="curid"></param>
    /// <param name="type"></param>
    public static void LoadCity(DropDownList drp, int curid, string type,int provinceid,string  headvalue)
    {
        string strSql = string.Format("select AutoID,Title from areacity  where status<>2  and provinceid={0}  order by OrderValue desc,AutoID asc ", provinceid);
        if (type == "view")
        {
            strSql = string.Format("select AutoID,Title from areacity  where  AutoID='{0}' ", curid);
        }
        DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
        ControlAndValue.ListControlDataBind(drp, dt, "Title", "AutoID", headvalue);
    }
   
    #endregion

    #region 绑定县区列表
    /// <summary>
    /// 绑定县区列表
    /// </summary>
    /// <param name="drp"></param>
    /// <param name="curid"></param>
    /// <param name="type"></param>
    public static void LoadCounty(DropDownList drp, int curid, string type, int cityid, string headvalue)
    {
        string strSql = string.Format("select AutoID,Title from areacounty  where status<>2  and cityid={0}  order by OrderValue desc,AutoID asc ", cityid);
        if (type == "view")
        {
            strSql = string.Format("select AutoID,Title from areacounty  where  AutoID='{0}' ", curid);
        }
        DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
        ControlAndValue.ListControlDataBind(drp, dt, "Title", "AutoID", headvalue);
    }

    #endregion 

    #region 绑定乡镇列表
    /// <summary>
    /// 绑定乡镇列表
    /// </summary>
    /// <param name="drp"></param>
    /// <param name="curid"></param>
    /// <param name="type"></param>
    public static void LoadTown(DropDownList drp, int curid, string type, int countyid, string headvalue)
    {
        string strSql = string.Format("select AutoID,Title from areatown  where status<>2  and countyid={0}  order by OrderValue desc,AutoID asc ", countyid);
        if (type == "view")
        {
            strSql = string.Format("select AutoID,Title from areatown  where  AutoID='{0}' ", curid);
        }
        DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
        ControlAndValue.ListControlDataBind(drp, dt, "Title", "AutoID", headvalue);
    }

    #endregion

    #region 绑定乡村列表
    /// <summary>
    /// 绑定乡村列表
    /// </summary>
    public static void LoadVillage(DropDownList drp, int townid, string headvalue)
    {
        string strSql = string.Format("select AutoID,Title from areavillage  where status<>2  and townid={0}  order by OrderValue desc,AutoID asc ", townid);
        DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
        ControlAndValue.ListControlDataBind(drp, dt, "Title", "AutoID", headvalue);
    }

    #endregion
   
    #region 根据镇ID,获取镇名称
    /// <summary>
    /// 根据镇ID,获取镇名称
    /// </summary>
    /// <param name="townId">镇ID</param>
    /// <returns></returns>
    public static string GetTownNameByID(int townId)
    {
        string returnValue = "";
        string strsql = string.Format("select Title from  areatown WHERE AutoID='{0}'", townId);
        DataTable dt = Query.ProcessSql(strsql, DataHelper.DataBase);
        if (dt != null && dt.Rows.Count > 0)
        {
            returnValue = dt.Rows[0][0].ToString();
        }
        return returnValue;
    }
    #endregion

    #region 根据村ID，获取村名称
    /// <summary>
    ///  根据村ID，获取村名称
    /// </summary>
    /// <param name="townId">村ID</param>
    /// <returns></returns>
    public static string GetVillageNameByID(int townId)
    {
        string returnValue = "";
        string strsql = string.Format("select Title from  areavillage WHERE AutoID='{0}'", townId);
        DataTable dt = Query.ProcessSql(strsql, DataHelper.DataBase);
        if (dt != null && dt.Rows.Count > 0)
        {
            returnValue = dt.Rows[0][0].ToString();
        }
        return returnValue;
    }
    #endregion 

    #region 首页轮播图
    /// <summary>
    ///  获取首页轮播图
    /// </summary>
     /// <returns></returns>
    public static DataTable GetLBImageDataTable(int townId,int customerId)
    {
        StringBuilder sb=new StringBuilder ();

        string strsql = string.Format("select AutoID,Title,FileUrl,FileSUrl  from webbeautifulvillageFile  where TownID='{0}' and FileType=2 and Status=1 and CustomerID='{1}' order by  OrderValue desc ", townId, customerId);
        return Query.ProcessSql(strsql, DataHelper.DataBase);
        
    }
    #endregion

}
