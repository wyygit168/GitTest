using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class test_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ImageUpload iu = new ImageUpload();
        iu.CustomerId = 7;
        iu.FormUploadFile = File1;
         
        FileEntity fe = iu.SaveImage();
        string fielpath = fe.FilePath;
        string  filespath = fe.FileSPath;
         
       
    }
}