﻿var login = {};
var Global_LoginPage_BaseHTMLData = "";

login.setPage = function () {
    login.LoadLobbyPageRes(true);
    let loginBtn = document.querySelector(".login-btn");
    loginBtn.onclick = login.onLoginClicked;
}

login.onLoginClicked = function(){
    // do something when btn is clicked
}

login.example = function(){
    Platform.SearchTemplate("some Keys", login.exampleReturnFunction);
}

login.exampleReturnFunction = function(iServerReturn){
    if (iServerReturn.Status != "OK"){
        // Error?
    }

    if (iServerReturn.StatusCode != 0){
        // Error?
    }

}

login.LoadLobbyPageRes = function (isSet) {
    $.ajax({
        url: "/WebApp/HTML/LoginPage.html",
        dataType: 'text',
        success: function (data) {
            Global_LoginPage_BaseHTMLData = data;
            if (isSet) {
                $("#MainAppWindow").html(data);
            }
        },
        error: function () {
            alert("error Loading Lobby Page");
        }
    });
}