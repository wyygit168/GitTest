using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;

/// <summary>
///ImageEntity 的摘要说明
/// </summary>
public class FileEntity
{

    #region 上传文件路径(虚拟路径)
    /// <summary>
    /// 上传文件路径(虚拟路径)
    /// </summary>
    public string FilePath
    {
        get;
        set;
    }
    #endregion

    #region 文件缩略图路径
    /// <summary>
    /// 文件缩略图路径
    /// </summary>
    public string FileSPath
    {
        get;
        set;
    }
    #endregion

    #region 操作标记
    /// <summary>
    /// 操作标记
    /// </summary>
    public string CompleteMark
    {
        get;
        set;
    }
    #endregion

}