var categories = ["Chees", "Vegetables"];


$(function () {
    $("#btSubmit").addEventListener("click", Summ);
});


function Get() {

    var arrData = {};
    arrData.iOpe1 = $("#txt_X").value;
    arrData.iOpe2 = $("#txt_Y").value;


    $.ajax({
        url: "http://localhost:7212/Service1.svc/TestEatConstGet",
        //data: JSON.stringify(arrData),
        type: "POST",
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
