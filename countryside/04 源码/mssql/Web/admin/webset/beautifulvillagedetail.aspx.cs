using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using BusinessEntity; 
using System.IO;
public partial class admin_webset_beautifulvillagedetail : SystemPopUpBasePage
{
    #region 属性
    /// <summary>
    /// 页面类型 ="" 乡村概述，=0 乡村图片，=1 乡村视频
    /// </summary>
    public string UrlType
    {
        get
        {
            string pagetype = "";
            if (Request.QueryString["pagetype"] != null)
            {
                pagetype = Request.QueryString["pagetype"].Trim();
            }
            return pagetype;
        }
    }
    #endregion

    #region 页面加载
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadScript();
            if(UrlType.Length==0) GetPageElementValue(); //乡村概述
            if (UrlType.Length > 0 && UrlType == "0") GetPageElementValueForImage();//乡村图片
        }
    }
    #endregion

    #region 保存乡村概述

    #region 获取乡村概述页面元素的值

    private void GetPageElementValue()
    {
        this.divImage.Style.Value = "display:none";
        this.divOverView.Style.Value = "display:''";
        UtilitySearch.LoadVillage(this.ddlVillageID, CurrentUser.TownID, "请选择乡村");
        if (Request.QueryString["curId"] != null)
        {
            int id = CommonMethod.ConvertToInt(Request.QueryString["curId"], 0);
            webbeautifulvillageEntity obj = new webbeautifulvillageEntity();
            obj.AutoID = id;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                ControlAndValue.GetValues4Control<webbeautifulvillageEntity>(this.divOverView, obj);
                ddlVillageID.SelectedValue = obj.VillageID.ToString();
              
            }
            
            txtAutoID.Text = id.ToString();
            if (Action == "view")
            { 
                this.btnSave.Visible = false; this.btnCancel.Visible = false;
            }
        }
    }

    #endregion

    #region 保存事件
    protected void btnSave_Click(object sender, EventArgs e)
    {
        #region 验证
        if (txtTitle.Text.Trim().Length == 0) { AlertError("标题不可以为空！"); Select(txtTitle); return; }
        if (ddlVillageID.SelectedValue.Length == 0) { AlertError("请选择所属农村！");  return; }
        #endregion

        int AutoId = CommonMethod.ConvertToInt(txtAutoID.Text, 0);
        webbeautifulvillageEntity objEntity = new webbeautifulvillageEntity();
        objEntity.AutoID = AutoId;
        objEntity.Retrieve();
        DateTime dtNow = DateTime.Now;
        if (!objEntity.IsPersistent)
        {
            objEntity.CreateDate = dtNow;
            objEntity.CreatorID = CurrentUser.AutoID;
        }

        objEntity.ModifyDate = dtNow;
        objEntity.Modifier = CurrentUser.AutoID;
        ControlAndValue.SetValues4Controls<webbeautifulvillageEntity>(this.divOverView, objEntity);
       
      
        objEntity.TownID = CurrentUser.TownID;
        objEntity.VillageID = ddlVillageID.SelectedValue.ToInt(0);
        objEntity.Save();
        setOverViewNull();
        if (AutoId <= 0) ExecScript("savesucceed();");
        else ExecScript("parent.returnfunction();");
    }
    #endregion

    #region 取消事件
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        int curId = CommonMethod.ConvertToInt(txtAutoID.Text, 0);
        if (curId > 0)
        {
            ExecScript("parent.ymPrompt.close();");
        }
        else
        {
            ExecScript("parent.ymPrompt.close();parent.succeed();");
        }
    }
    #endregion

    #region   清除乡村概述控件值

    /// <summary>
    /// 清除乡村概述控件值
    /// </summary>
    private void setOverViewNull()
    {
        foreach (Control var in this.form1.Controls)
        {
            if (var.ID != null && var.ID.Contains("txt"))
            {
                TextBox tBox = (TextBox)var;
                if (tBox != null) { tBox.Text = ""; }
            }
        }
        this.ddlStatus.SelectedValue = "1";
    }

    #endregion 

    #endregion

    #region 保存图片

    #region 获取乡村图片页面元素的值

    private void GetPageElementValueForImage()
    {
        this.divImage.Visible= true;
        this.divOverView.Visible = false;
        UtilitySearch.LoadVillage(this.drpImgVillage, CurrentUser.TownID, "请选择乡村");
        if (Request.QueryString["curId"] != null)
        {
            int id = CommonMethod.ConvertToInt(Request.QueryString["curId"], 0);
            spanFileImageNew.Visible = false;
            webbeautifulvillageFileEntity obj = new webbeautifulvillageFileEntity();
            obj.AutoID = id;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                this.trImageView.Visible = true;
                this.FileImageUpdate.Visible = true;
                this.FileImageNew.Visible = false;
                drpImgVillage.SelectedValue = obj.VillageID.ToString();
                txtImageTitle.Text = obj.Title;
                //txtImageLinkUrl.Text = obj.LinkUrl;
                txtImageOrderValue.Text = obj.OrderValue.ToString();
                txtAutoID.Text = id.ToString();
                aimage.HRef = imgView.ImageUrl = CurrentDomainRootPath + obj.FileUrl;
                aimage.Target = "_blank";
            } 
            txtAutoID.Text = id.ToString();
            if (Action == "view")
            {
                this.btnSaveImage.Visible = false; this.btnCancleImage.Visible = false;
            }
        }
    }

    #endregion

    protected void btnSaveImage_Click(object sender, EventArgs e)
    {
        int AutoId = CommonMethod.ConvertToInt(txtAutoID.Text, 0); 
         
         #region 验证
        if (txtImageTitle.Text.Trim().Length == 0)
        {
            { AlertError("图片标题不可以为空！"); Select(txtImageTitle); return; }
        }
        if (AutoId==0 && FileImageNew.Value.Trim().Length == 0)
        {
            { AlertError("请上传图片！"); Select(FileImageNew); return; }
        }
        if (drpImgVillage.SelectedValue.Length == 0)
        {
            AlertError("请选择乡村！"); //Select(drpImgVillage);
            return;
        }
        #endregion
        string filesurl = "";
        string fileurl ="";
        webbeautifulvillageFileEntity objEntity = new webbeautifulvillageFileEntity();
        objEntity.AutoID = AutoId;
        objEntity.Retrieve();
        DateTime dtNow = DateTime.Now;
        //objEntity.LinkUrl = txtImageLinkUrl.Text.Trim();
        ImageUpload iu = new ImageUpload();
         FileEntity fe =new FileEntity ();
        if (AutoId == 0 || FileImageUpdate.Value.Length > 0)
        {
            iu.CustomerId = CurrentCustomerID;
            iu.Width = 800;
            iu.Height = 600;
            iu.SWidth = 220;
            iu.SHeight = 155;
            iu.IsCreateImg = true;
            iu.IsDraw = false;
        }
        if (!objEntity.IsPersistent)
        {
            objEntity.CustomerID = CurrentCustomerID;
            objEntity.CreateDate = dtNow;
            objEntity.CreatorID = CurrentUser.AutoID;
            iu.FormUploadFile = this.FileImageNew;
            objEntity.TownID = CurrentUser.TownID;
            objEntity.FileType = "0";
            fe = iu.SaveImage();
            objEntity.FileUrl = fe.FilePath;
            objEntity.FileSUrl = fe.FileSPath;
        }
        else
        {
            if (FileImageUpdate.Value.Length > 0)
            {
                iu.FormUploadFile = this.FileImageUpdate;
                fe= iu.SaveImage();
                filesurl =CurrentDomainRootPath+objEntity.FileSUrl;
                fileurl =CurrentDomainRootPath + objEntity.FileUrl;
                objEntity.FileUrl = fe.FilePath;
                objEntity.FileSUrl = fe.FileSPath;
            } 
        }
        //objEntity.LinkUrl = txtImageLinkUrl.Text.Trim();
        objEntity.Title = txtImageTitle.Text.Trim();
        objEntity.ModifyDate = dtNow;
        objEntity.Modifier = CurrentUser.AutoID;
        objEntity.VillageID = drpImgVillage.SelectedValue.ToInt(0);
        objEntity.OrderValue = txtImageOrderValue.Text.ToInt(0);
        objEntity.Status = chkImageStatus.Checked ? 1 : 0;
        objEntity.FileType ="0";
        objEntity.Save();

        setImageNull();
        if (AutoId <= 0) ExecScript("savesucceed();");
        else
        {
            if (fe != null && FileImageUpdate.Value.Length > 0 && fe.CompleteMark == "恭喜，图片上传成功!")
            {
                if (File.Exists(filesurl)) File.Delete(filesurl);
                if (File.Exists(fileurl)) File.Delete(fileurl); 
            }
            ExecScript("parent.returnfunction();");
        } 
    }

    protected void btnCancleImage_Click(object sender, EventArgs e)
    {
        int curId = CommonMethod.ConvertToInt(txtAutoID.Text, 0);
        if (curId > 0)
        {
            ExecScript("parent.ymPrompt.close();");
        }
        else
        {
            ExecScript("parent.ymPrompt.close();parent.succeed();");
        }
    }

    /// <summary>
    /// 清空图片模块下的控件值
    /// </summary>
    public void setImageNull()
    {
        //txtImageLinkUrl.Text = "";
        txtImageTitle.Text = "";
        txtImageOrderValue.Text = "0";
        chkImageStatus.Checked = true;
        drpImgVillage.SelectedValue = "";
        //if (autoid > 0) FileImageUpdate.Value = "";
        //else FileImageNew.Value = "";
    }
    
    #endregion

    #region 加载Js文件
    /// <summary>
    /// 加载Js文件
    /// </summary>
    private void LoadScript()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/admin/webset/dataset.js?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/admin/webset/beautifulvillagedetail.aspx.js?v=" + CommonMethod.Version);
        litScript.Text = sb.ToString();
    }
    #endregion
   
}