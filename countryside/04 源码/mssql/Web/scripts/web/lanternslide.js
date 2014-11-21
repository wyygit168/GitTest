var FocusPic = function (BigPicID, SmallPicsID, TitleID, DisplayType) {
    this.Data = [];
    this.ImgLoad = [];
    this.TimeOut = 5000;
    var adNum = 0, TimeOutObj;
    if (!FocusPic.childs) { FocusPic.childs = [] };
    this.ID = FocusPic.childs.push(this) - 1;
    this.Add = function (BigPic, SmallPic, Title, Url) {
        var ls;
        this.Data.push([BigPic, SmallPic, Title, Url]);
        ls = this.ImgLoad.length;
        this.ImgLoad.push(new Image);
        this.ImgLoad[ls].src = BigPic
    };
    this.TimeOutBegin = function () {
        clearInterval(TimeOutObj);
        TimeOutObj = setInterval('FocusPic.childs[' + this.ID + '].next()', this.TimeOut)
    };
    this.TimeOutEnd = function () { clearInterval(TimeOutObj) };
    this.select = function (num) {
        if (num > this.Data.length - 1) { return };
        this.TimeOutBegin();
        this.adNum = num;
        if (BigPicID) {
            if (document.getElementById(BigPicID)) {
                var aObj = document.getElementById(BigPicID).getElementsByTagName('a')[0], aImg = document.getElementById(BigPicID).getElementsByTagName('img')[0];
                if (aImg.filters) {
                    aImg.filters.revealTrans.Transition = 23;
                    aImg.filters.revealTrans.apply();
                    aImg.filters.revealTrans.play()
                };
                aObj.href = this.Data[num][2];
                aImg.alt = this.Data[num][3];
                aImg.src = this.Data[num][0]
            } 
        };
        if (TitleID) {
            if (document.getElementById(TitleID)) {
                document.getElementById(TitleID).innerHTML = '<a href="' + this.Data[num][2] + '" target="_blank">' + this.Data[num][3] + '</a>'
            } 
        };
        if (SmallPicsID) {
            if (document.getElementById(SmallPicsID)) {
                var sImg = document.getElementById(SmallPicsID).getElementsByTagName('span'), i;
                for (i = 0; i < sImg.length; i++) {
                    if (i == num) {
                        sImg[i].className = 'selected'
                    }
                    else {
                        sImg[i].className = ''
                    } 
                } 
            } 
        } 
    };
    this.next = function () {
        var temp = this.adNum;
        temp++;
        if (temp >= this.Data.length) {
            temp = 0
        };
        this.select(temp)
    };
    this.MInStopEvent = function (ObjID) {
        if (ObjID) {
            if (document.getElementById(ObjID)) {
                if (document.getElementById(ObjID).attachEvent) {
                    document.getElementById(ObjID).attachEvent('onmouseover', Function('FocusPic.childs[' + this.ID + '].TimeOutEnd()'));
                    document.getElementById(ObjID).attachEvent('onmouseout', Function('FocusPic.childs[' + this.ID + '].TimeOutBegin()'))
                }
                else {
                    document.getElementById(ObjID).addEventListener('mouseover', Function('FocusPic.childs[' + this.ID + '].TimeOutEnd()'), false);
                    document.getElementById(ObjID).addEventListener('mouseout', Function('FocusPic.childs[' + this.ID + '].TimeOutBegin()'), false)
                } 
            } 
        } 
    };
    this.begin = function () {
        this.MInStopEvent(TitleID);
        this.MInStopEvent(SmallPicsID);
        this.MInStopEvent(BigPicID);
        if (SmallPicsID) {
            if (document.getElementById(SmallPicsID)) {
                var i, temp = '';
                for (i = 0; i < this.Data.length; i++) {
                    if (DisplayType == 1) {
                        temp += '<span><div class="imgItem"><a href="' + this.Data[i][2] + '" target="_blank"><img src="' + this.Data[i][1] + '" onmouseover="FocusPic.childs[' + this.ID + '].select(' + i + ')" alt="' + this.Data[i][3] + '" /></a></div></span>'
                    }
                    else if (DisplayType == 2) {
                        temp += '<span onmouseover="FocusPic.childs[' + this.ID + '].select(' + i + ')" title="' + this.Data[i][3] + '" />' + this.Data[i][1] + '</span>'
                    }
                    else if (DisplayType == 3) {
                        temp += '<span onmouseover="FocusPic.childs[' + this.ID + '].select(' + i + ')" title="' + this.Data[i][3] + '" />' + this.Data[i][3] + '</span>'
                    }
                }
                document.getElementById(SmallPicsID).innerHTML = temp
            } 
        };
        this.select(0)
    };
    this.$ = function (objName) {
        if (document.getElementById) {
            return eval('document.getElementById("' + objName + '")')
        }
        else { return eval('document.all.' + objName) } 
    }
}