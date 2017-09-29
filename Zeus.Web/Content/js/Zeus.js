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