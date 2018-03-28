var categories = ["Chees", "Vegetables"];


$(function () {
    $("#modalSignInBtn").on("click", PostValidateUser);


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
    $('#SignInloginInput').val("");
    document.getElementById("SignInpasswordInput").value = "";

    $("#modalSignInBtn").click(function () {
        $("#SignInWindow").modal("hide");
        $("SignUpBtn").hide();


    })
}

function GetAllCategories() {
	return new Promise(function (resolve, reject) {
		$.ajax({
			url: "http://10.7.180.110/GastroService/Service1.svc/CategoriesToReturn",
			//url: "http://localhost:7212/Service1.svc/CategoriesToReturn",
			type: "POST",
			dataType: "json",
			contentType: "application/json; charset=utf-8",
			success: function (data) {
				console.log(data);
				resolve(data);
			},
			error: function (XMLHttpRequest, textStatus, errorThrown) {
				console.log(textStatus);
				reject(textStatus);
			}
		});
	});
}

function GetMealsForConstructor() {
	return new Promise(function (resolve, reject) {
		$.ajax({
            url: "http://10.7.180.110/GastroService/Service1.svc/GetIngredientsForConstructor",
			//url: "http://localhost:7212/Service1.svc/TestEatConstGet",
			type: "POST",
			dataType: "json",
			contentType: "application/json; charset=utf-8",
			success: function (data) {
				console.log(data);
				resolve(data);
			},
			error: function (XMLHttpRequest, textStatus, errorThrown) {
				console.log(textStatus);
				reject(textStatus);
			}
		});
	});
}

function GetMeals(page, elemsPerPage) {
	return new Promise(function (resolve, reject) {
		$.ajax({
			url: "http://10.7.180.110/GastroService/Service1.svc/GetMeals",
			//url: "http://localhost:7212/Service1.svc/GetMeals",
			type: "POST",
			data: JSON.stringify({ pageNum: page, elementsForPage: elemsPerPage }),
			dataType: "json",
			contentType: "application/json; charset=utf-8",
			success: function (data) {
				console.log(data);
				resolve(data);
			},
			error: function (XMLHttpRequest, textStatus, errorThrown) {
				console.log(textStatus);
				reject(textStatus);
			}
		});
	});
}