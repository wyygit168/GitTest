using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Drawing;

/// <summary>
///ImageUpload 的摘要说明
/// </summary>
public class ImageUpload
{

    #region 字段
    private int _MaxSize = 5120000;//最大单个上传文件 (默认)
    private string _FileType = "jpg/gif/bmp/png";//所支持的上传类型用"/"隔开 
    private int _SaveType = 0;//上传文件的类型，0代表自动生成文件名 
    private string _InFileName = "";//非自动生成文件名设置。 
    private bool _IsCreateImg = false;//是否生成缩略图。 
    private bool _Iss = false;//是否有缩略图生成.
    private int _Height = 0;//获取上传图片的高度 
    private int _Width = 0;//获取上传图片的宽度 
    private int _sHeight = 120;//设置生成缩略图的高度 
    private int _sWidth = 120;//设置生成缩略图的宽度
    private bool _IsDraw = false;//设置是否加水印
    private int _DrawStyle = 1;//设置加水印的方式０：文字水印模式，１：图片水印模式,2:不加
    private int _DrawString_x = 10;//绘制文本的Ｘ坐标（左上角）
    private int _DrawString_y = 10;//绘制文本的Ｙ坐标（左上角）
    private string _AddText = "杭州五维多媒体\nHTTP://WWW.5D.CN";//设置水印内容
    private string _Font = "宋体";//设置水印字体
    private int _FontSize = 124;//设置水印字大小
    private int _FileSize = 0;//获取已经上传文件的大小
    #endregion

    #region 属性

    #region 客户ID
    /// <summary>
    /// 客户ID
    /// </summary>
    public int CustomerId
    {
        get;
        set;
    }
    #endregion 

    #region 操作标记
    /// <summary>
    /// 操作标记
    /// </summary>
    public struct CompletMark
    {
        public const string NoSelectFile = "很抱歉，请选择上传图片";
        public const string NoType = "很抱歉，请选择jpg/gif/bmp/png的图片类型!";
        public const string NoSize = "很抱歉，图片大小超出限制!";
        public const string NoSuccess = "很抱歉，图片上传失败，请稍后在试!";
        public const string Success = "恭喜，图片上传成功!";
    }
    #endregion

    #region 最大单个上传文件
    /// <summary>
    /// 最大单个上传文件
    /// </summary>
    public int MaxSize
    {
        set { _MaxSize = value; }
        get {return  _MaxSize; }
    }
    #endregion

    #region 所支持的上传类型用"/"隔开
    /// <summary>
    /// 所支持的上传类型用"/"隔开 
    /// </summary>
    public string FileType
    {
        set { _FileType = value; }
        get{return  _FileType;}
    }
    #endregion

    #region 保存文件的实际路径
    /// <summary>
    /// //保存文件的实际路径 
    /// </summary>
    public string SavePath
    {
        get
        {
            string uploadFullFolderPath = HttpContext.Current.Server.MapPath("~/") + VirturlPath;
            if (!Directory.Exists(uploadFullFolderPath))
            {
                Directory.CreateDirectory(uploadFullFolderPath);
            }
            return uploadFullFolderPath;
        }
    }
    #endregion 

    #region 虚拟路径
    /// <summary>
    /// 虚拟路径
    /// </summary>
    public string VirturlPath
    {
        get
        { 
            string Yeah = DateTime.Now.Year.ToString();
            string Month = DateTime.Now.Month.ToString();
            string Day = DateTime.Now.Day.ToString();
            return CommonMethod.GetConfigValueByKey("Upload") +  CustomerId + "/" + Yeah + "/" + Month + "/" + Day + "/";
        }
    }
    #endregion

    #region 上传文件的类型，0代表自动生成文件名
    /// <summary>
    /// 上传文件的类型，0代表自动生成文件名
    /// </summary>
    public int SaveType
    { 
        set { _SaveType = value; }
        get{return  _SaveType;}
    }
    #endregion

    #region 上传控件
    /// <summary>
    /// 上传控件
    /// </summary>
    public HtmlInputFile FormUploadFile
    {
        get;
        set;
    }
    #endregion

    #region 非自动生成文件名设置。
    /// <summary>
    /// //非自动生成文件名设置。
    /// </summary>
    public string InFileName
    {
        set { _InFileName = value; }
        get {return _InFileName;}
    }
    #endregion

    #region 是否有缩略图生成.
    /// <summary>
    /// 是否有缩略图生成.
    /// </summary>
    public bool Iss
    {
        get { return _Iss; }
        set { _Iss=value;}
    }
    #endregion

    #region 获取上传图片的宽度
    /// <summary>
    /// //获取上传图片的宽度
    /// </summary>
    public int Width
    {
        get { return _Width; }
        set {_Width=value;}
    }
    #endregion

    #region 获取上传图片的高度
    /// <summary>
    /// //获取上传图片的高度
    /// </summary>
    public int Height
    {
        get { return _Height; }
        set{_Height=value;}
    }
    #endregion

    #region 设置缩略图的宽度
    /// <summary>
    /// 设置缩略图的宽度
    /// </summary>
    public int SWidth
    {
        get { return _sWidth; }
        set { _sWidth = value; }
    }
    #endregion

    #region 设置缩略图的高度
    /// <summary>
    /// 设置缩略图的高度
    /// </summary>
    public int SHeight
    {
        get { return _sHeight; }
        set { _sHeight = value; }
    }
    #endregion

    #region 是否生成缩略图
    /// <summary>
    /// 是否生成缩略图
    /// </summary>
    public bool IsCreateImg
    {
        get { return _IsCreateImg; }
        set { _IsCreateImg = value; }
    }
    #endregion

    #region 是否加水印
    /// <summary>
    /// 是否加水印
    /// </summary>
    public bool IsDraw
    {
        get { return _IsDraw; }
        set { _IsDraw = value; }
    }
    #endregion

    #region 设置加水印的方式０：文字水印模式，１：图片水印模式
    /// <summary>
    /// 设置加水印的方式０：文字水印模式，１：图片水印模式
    /// </summary>
    public int DrawStyle
    {
        get { return _DrawStyle; }
        set { _DrawStyle = value; }
    }
    #endregion

    #region 绘制文本的Ｘ坐标（左上角）
    /// <summary>
    /// 绘制文本的Ｘ坐标（左上角）
    /// </summary>
    public int DrawString_x
    {
        get { return _DrawString_x; }
        set { _DrawString_x = value; }
    }
    #endregion

    #region 绘制文本的Ｙ坐标（左上角）
    /// <summary>
    /// 绘制文本的Ｙ坐标（左上角）
    /// </summary>
    public int DrawString_y
    {
        get { return _DrawString_y; }
        set { _DrawString_y = value; }
    }
    #endregion

    #region 设置文字水印内容
    /// <summary>
    /// 设置文字水印内容
    /// </summary>
    public string AddText
    {
        get { return _AddText; }
        set { _AddText = value; }
    }
    #endregion

    #region 设置文字水印字体
    /// <summary>
    /// 设置文字水印字体
    /// </summary>
    public string Font
    {
        get { return _Font; }
        set { _Font = value; }
    }
    #endregion

    #region 设置文字水印字的大小
    /// <summary>
    /// 设置文字水印字的大小
    /// </summary>
    public int FontSize
    {
        get { return _FontSize; }
        set { _FontSize = value; }
    }
    #endregion

    #region  文件大小
    /// <summary>
    /// 文件大小
    /// </summary>
    public int FileSize
    {
        get { return _FileSize; }
        set { _FileSize = value; }
    }

    #endregion

    #region 图片水印模式下的覆盖图片的实际地址
    /// <summary>
    /// 图片水印模式下的覆盖图片的实际地址
    /// </summary>
    public string CopyIamgePath
    {
        get
        {
            string _CopyIamgePath = HttpContext.Current.Server.MapPath("~/images/watermark/gongshang.png");
            return _CopyIamgePath;
        }
    }
    #endregion

    #endregion

    #region 获取上传文件的后缀名
    /// <summary>
    /// 获取上传文件的后缀名 
    /// </summary>
    /// <param name="path">路径</param>
    /// <returns></returns>
    private string GetExt(string path)
    {
        return Path.GetExtension(path);
    }
    #endregion

    #region 获取输出文件的文件名。 
   /// <summary>
   ///  获取输出文件的文件名。
   /// </summary>
   /// <param name="Ext">上传文件的后缀名</param>
   /// <returns></returns>
    private string FileName(string Ext)
    {
        if (SaveType == 0 || _InFileName.Trim() == "")
            return DateTime.Now.ToString("yyyyMMddHHmmssfff") + Ext;
        else
            return _InFileName;
    }
    #endregion 

    #region 检查上传的文件的类型，是否允许上传。 
    /// <summary>
    /// 检查上传的文件的类型，是否允许上传。 
    /// </summary>
    /// <param name="Ext">上传文件的后缀名</param>
    /// <returns></returns>
    private bool IsUpload(string Ext)
    {
        Ext = Ext.Replace(".", "");
        bool b = false;
        string[] arrFileType = FileType.Split('/');
        foreach (string str in arrFileType)
        {
            if (str.ToLower() == Ext.ToLower())
            {
                b = true;
                break;
            }
        }
        return b;
    }
    #endregion

    #region 图片上传
    /// <summary>
    /// 图片上传
    /// </summary>
    public FileEntity SaveImage()
    {
        FileEntity fe = new FileEntity();
        string sFname = "";
        string FName = "";
        string strCompleteMark="";
        HttpPostedFile hpFile = FormUploadFile.PostedFile;
        if (hpFile == null || hpFile.FileName.Trim() == "")strCompleteMark= CompletMark.NoSelectFile; 
        string Ext = GetExt(hpFile.FileName);  if (!IsUpload(Ext))  strCompleteMark= CompletMark.NoType; 
        int iLen = hpFile.ContentLength; if (iLen >MaxSize) strCompleteMark= CompletMark.NoSize;
        try
        {

            byte[] bData = new byte[iLen];
            hpFile.InputStream.Read(bData, 0, iLen);
            FName = FileName(Ext);
            string TempFile = "";
            if (IsDraw) TempFile = FName.Split('.').GetValue(0).ToString() + "_temp." + FName.Split('.').GetValue(1).ToString();
            else TempFile = FName;

            #region 上传图片，如果是需要添加水印，上传临时图片，否则上传正式图片
            FileStream newFile = new FileStream(SavePath + TempFile, FileMode.Create);
            newFile.Write(bData, 0, bData.Length);
            newFile.Flush();
            int _FileSizeTemp = hpFile.ContentLength;
            #endregion

            #region 如果需要添加水印，在上传的照片上添加水印
            if (IsDraw)
            {
                if (DrawStyle == 0)  //添加文字水印
                {
                    System.Drawing.Image Img1 = System.Drawing.Image.FromStream(newFile);
                    Graphics g = Graphics.FromImage(Img1);
                    g.DrawImage(Img1, 100, 100, Img1.Width, Img1.Height);
                    Font f = new Font(Font, FontSize);
                    Brush b = new SolidBrush(Color.Red);
                    string addtext = _AddText;
                    g.DrawString(addtext, f, b, _DrawString_x, _DrawString_y);
                    g.Dispose();
                    Img1.Save(SavePath + FName);
                    Img1.Dispose();
                }
                else if (DrawStyle == 1)  //添加图片水印
                {
                    System.Drawing.Image image = System.Drawing.Image.FromStream(newFile);
                    System.Drawing.Image copyImage = System.Drawing.Image.FromFile(CopyIamgePath);
                    Graphics g = Graphics.FromImage(image);
                    g.DrawImage(copyImage, new Rectangle(image.Width - copyImage.Width - 5, image.Height - copyImage.Height - 5, copyImage.Width, copyImage.Height), 0, 0, copyImage.Width, copyImage.Height, GraphicsUnit.Pixel);
                    g.Dispose();
                    image.Save(SavePath + FName);
                    image.Dispose();
                }
            }
            #endregion

            #region 如果设置生成缩略图，即生成缩略图

            if (IsCreateImg)//设置缩略图部分 
            {
                //获取图片的高度和宽度
                System.Drawing.Image Img = System.Drawing.Image.FromStream(newFile);
                Width = Img.Width;
                Height = Img.Height;

                if (iLen > 15360)//如果上传文件小于15k，则不生成缩略图。 
                {
                    System.Drawing.Image newImg = Img.GetThumbnailImage(_sWidth, _sHeight, null, System.IntPtr.Zero);
                    sFname = FName.Split('.').GetValue(0).ToString() + "_s." + FName.Split('.').GetValue(1).ToString();
                    newImg.Save(SavePath + sFname);
                    newImg.Dispose();
                    Iss = true;
                }
                else
                {
                    sFname = FName; 
                }
            }
            #endregion

            #region 如果是添加水印，
            if (IsDraw)
           {
                if (File.Exists(SavePath + FName.Split('.').GetValue(0).ToString() + "_temp." + FName.Split('.').GetValue(1).ToString()))
                {
                    newFile.Dispose();
                    File.Delete(SavePath + FName.Split('.').GetValue(0).ToString() + "_temp." + FName.Split('.').GetValue(1).ToString());
                }
           }
            #endregion 

           #region 释放资源
           newFile.Close();
           newFile.Dispose();
           FileSize = _FileSizeTemp;
           strCompleteMark =CompletMark.Success;
            #endregion
         
        }
        catch
        {
             strCompleteMark= CompletMark.NoSuccess;
        }

        fe.FilePath = VirturlPath + FName;
        fe.FileSPath = VirturlPath + sFname;
        fe.CompleteMark = strCompleteMark;
        return fe;
    }
    #endregion

}