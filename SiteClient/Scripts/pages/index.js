var categories = ["Chees", "Vegetables"];


$(function () {
    $("#signInBtn").on("click", PostValidateUser);

    loadMainProductList();

});


function PostValidateUser() {

    var arrData = {};
    arrData.login =   $("#loginInput").val();
    arrData.password = $("#passwordInput").val();

    console.log(arrData);

    $.ajax({
        url: "http://10.7.180.110/GastroService/Service1.svc/ValidateUser",

        type: "POST",
        data: JSON.stringify(arrData),
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            console.log(data);
            //alert(data);
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log(textStatus);
        }
    });

}
