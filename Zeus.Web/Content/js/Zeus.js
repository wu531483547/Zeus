//功能描述:获取服务器全路径
//维护时间:[2017-09-29]
//维护人员:Rex
var GetRootPath = function () {
    //获取当前网址，如： http://localhost:8083/proj/meun.jsp 
    var curWwwPath = window.document.location.href;
    //获取主机地址之后的目录，如： proj/meun.jsp 
    var pathName = window.document.location.pathname;
    var pos = curWwwPath.indexOf(pathName);
    //获取主机地址，如： http://localhost:8083 
    var localhostPath = curWwwPath.substring(0, pos);
    //获取带"/"的项目名，如：/proj 
    var projectName = pathName.substring(0, pathName.substr(1).indexOf('/') + 1);
    //return (localhostPath + projectName);
    return localhostPath;
};

//功能描述:JS获取页面传递的参数
//维护时间:[2017-09-29]
//维护人员:Rex
function request(paras) {
    var url = window.location.href;
    var paraString = url.split('?').pop().split('&');
    var paraObj = {}
    for (var i = 0; i < paraString.length; i++) {
        var tmpa = paraString[i].split("=");
        paraObj[tmpa[0].toLowerCase()] = tmpa[1] ? tmpa[1] : "";
    }
    var returnValue = paraObj[paras.toLowerCase()];
    if (typeof (returnValue) == "undefined") {
        return "";
    } else {
        return returnValue;
    }
}

//功能描述:数字金额大写转换(可以处理整数,小数,负数)
//维护时间:[2017-10-20]
//维护人员:Rex
function smalltoBIG(n) {
    var fraction = ['角', '分'];
    var digit = ['零', '壹', '贰', '叁', '肆', '伍', '陆', '柒', '捌', '玖'];
    var unit = [['元', '万', '亿'], ['', '拾', '佰', '仟']];
    var head = n < 0 ? '欠' : '';
    n = Math.abs(n);

    var s = '';

    for (var i = 0; i < fraction.length; i++) {
        s += (digit[Math.floor(n * 10 * Math.pow(10, i)) % 10] + fraction[i]).replace(/零./, '');
    }
    s = s || '整';
    n = Math.floor(n);

    for (var i = 0; i < unit[0].length && n > 0; i++) {
        var p = '';
        for (var j = 0; j < unit[1].length && n > 0; j++) {
            p = digit[n % 10] + unit[1][j] + p;
            n = Math.floor(n / 10);
        }
        s = p.replace(/(零.)*零$/, '').replace(/^$/, '零') + unit[0][i] + s;
    }
    return head + s.replace(/(零.)*零元/, '元').replace(/(零.)+/g, '零').replace(/^整$/, '零元整');
}

//功能描述:格式化Ext时间
//维护时间:[2017-10-20]
//维护人员:Rex
function formatExtTime(vExtTime, vFormatText) {
    if (vFormatText == undefined || vFormatText == '') {
        vFormatText = 'yyyy-MM-dd';
    }
    var vTime = new Date(vExtTime);
    var v_Month = (vTime.getMonth() + 1);
    var v_FullMonth = parseInt(v_Month) < 10 ? ("0" + v_Month) : v_Month;
    return vFormatText.replace('yyyy', vTime.getFullYear())
                      .replace('MM', v_FullMonth)
                      .replace('M', v_Month)
                      .replace('dd', vTime.getDate());
}