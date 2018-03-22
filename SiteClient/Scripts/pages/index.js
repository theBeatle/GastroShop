﻿var categories = ["Chees", "Vegetables"];


$(function () {
    $("#signInBtn").on("click", PostValidateUser);


    $.ajax({
        url: 'Pages/productTable.html',
        success: function (data) {
            $('#mainContainer').html(data); // Load data into a <div> as HTML
            console.log('The page was loaded!');

            loadMainProductList();
        }

    });



});


function PostValidateUser() {

    var arrData = {};
    arrData.login =   $("#SignInloginInput").val();
    arrData.password = $("#SignInpasswordInput").val();

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
    document.getElementById("SignInloginInput").value = "";
    document.getElementById("SignInpasswordInput").value = "";

    $("#signInBtn").click(function () {
        $("#SignInWindow").modal("hide");
    })
}


