function CheckLogin() {
    if (document.getElementById("txtName").value.replace(/\s/g, "") == "") {
        ymPrompt.errorInfo({ title: '温馨提示', message: '请输入登录名', handler: function() {
            document.getElementById("txtName").focus();
        }
        });
        return false;
    }
    if (document.getElementById("txtPassword").value.replace(/\s/g, "") == "") {
        ymPrompt.errorInfo({ title: '温馨提示', message: '请输入密码', handler: function() {
            document.getElementById("txtPassword").focus();
        }
        });
        return false;
    }

}