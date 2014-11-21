//****************************************************************
// 保存成功后提示
//****************************************************************

function savesucceed() {
    ymPrompt.confirmInfo({ title: '保存成功', message: '信息保存成功，还要继续添加吗？', handler: function(tp) {
        if (tp != 'ok') { parent.ymPrompt.close(); parent.succeed(); }
    }
})
}

var pagestaus = "2";
