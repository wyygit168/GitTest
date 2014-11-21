using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessEntity;

public partial class admin_webset_imagesetdetail : SystemPopUpBasePage
{

    #region 属性
    /// <summary>
    /// 页面类型 ="" 首页轮播图， 
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


    #region 初始化
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadScript();
            #region 轮播图显示
            if (UrlType.Length == 0) GetPageElementValueForImage();
            #endregion
        }
    }


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
    #endregion


    #region 轮播图

    #region 获取首页轮播图元素的值

    private void GetPageElementValueForImage()
    {
        this.divImage.Visible = true; 
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
        if (AutoId == 0 && FileImageNew.Value.Trim().Length == 0)
        {
            { AlertError("请上传图片！"); Select(FileImageNew); return; }
        }
        
        #endregion
        string filesurl = "";
        string fileurl = "";
        webbeautifulvillageFileEntity objEntity = new webbeautifulvillageFileEntity();
        objEntity.AutoID = AutoId;
        objEntity.Retrieve();
        DateTime dtNow = DateTime.Now;
        //objEntity.LinkUrl = txtImageLinkUrl.Text.Trim();
        ImageUpload iu = new ImageUpload();
        FileEntity fe = new FileEntity();
        if (AutoId == 0 || FileImageUpdate.Value.Length > 0)
        {
            iu.CustomerId = CurrentCustomerID;
            iu.Width = 960;
            iu.Height = 120;
            iu.SWidth = 960;
            iu.SHeight = 120;
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
            objEntity.FileType = "2"; //轮播图类型
            fe = iu.SaveImage();
            objEntity.FileUrl = fe.FilePath;
            objEntity.FileSUrl = fe.FileSPath;
        }
        else
        {
            if (FileImageUpdate.Value.Length > 0)
            {
                iu.FormUploadFile = this.FileImageUpdate;
                fe = iu.SaveImage();
                filesurl = CurrentDomainRootPath + objEntity.FileSUrl;
                fileurl = CurrentDomainRootPath + objEntity.FileUrl;
                objEntity.FileUrl = fe.FilePath;
                objEntity.FileSUrl = fe.FileSPath;
            }
        }
        //objEntity.LinkUrl = txtImageLinkUrl.Text.Trim();
        objEntity.Title = txtImageTitle.Text.Trim();
        objEntity.ModifyDate = dtNow;
        objEntity.Modifier = CurrentUser.AutoID;
         
        objEntity.OrderValue = txtImageOrderValue.Text.ToInt(0);
        objEntity.Status = chkImageStatus.Checked ? 1 : 0;
        objEntity.FileType = "2";
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

    protected void btnSave_Click(object sender, EventArgs e)
    {
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
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
        //if (autoid > 0) FileImageUpdate.Value = "";
        //else FileImageNew.Value = "";
    }

    #endregion














     

}