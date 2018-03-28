var amountOfPage = 20;
var meals;

function PageNavigationUpdate() {
    $("#products-nav li").removeClass("active").removeClass("disabled");
    if (amountOfPage > 15) {
        var curAm = $("#products-nav li").length;
        $("#products-nav li:eq(2)").nextUntil("#products-nav li:eq(" + (curAm - 2) + ")").remove();
        $("#products-nav li").removeClass("disabled");
        if (page > 4 && page < amountOfPage - 3) {
            $("<li class='page-item'><a class='page-link' href='#'>...</a></li>").insertAfter("#products-nav li:eq(2)");
            $("<li class='page-item' onclick='ChangePage(this)'><a class='page-link' href='#'>" + (page - 1) + "</a></li>").insertAfter("#products-nav li:eq(3)");
            $("<li class='page-item active'><a class='page-link' href='#'>" + page + "</a></li>").insertAfter("#products-nav li:eq(4)");
            $("<li class='page-item' onclick='ChangePage(this)'><a class='page-link' href='#'>" + (page + 1) + "</a></li>").insertAfter("#products-nav li:eq(5)");
            $("<li class='page-item'><a class='page-link' href='#'>...</a></li>").insertAfter("#products-nav li:eq(6)");
        }
        else if (page > 4) {
            $("<li class='page-item'><a class='page-link' href='#'>...</a></li>").insertAfter("#products-nav li:eq(2)");
            for (let i = amountOfPage - 6; i < amountOfPage; ++i) {
                $("<li class='page-item' onclick='ChangePage(this)'><a class='page-link' href='#'>" + i + "</a></li>").insertBefore("#products-nav li:not(#products-nav li:last):last");
            }
            curAm = $("#products-list li").length - 2;
            $("#products-nav li:eq(" + (curAm - (amountOfPage - page)) + ")").addClass("active");
        }
        else if (page < amountOfPage - 3) {
            for (let i = 3; i < 7; ++i) {
                $("<li class='page-item' onclick='ChangePage(this)'><a class='page-link' href='#'>" + i + "</a></li>").insertBefore("#products-nav li:not(#products-nav li:last):last");
            }
            $("<li class='page-item'><a class='page-link' href='#'>...</a></li>").insertBefore("#products-nav li:not(#products-nav li:last):last");
            $("#products-nav li:eq(" + page + ")").addClass("active");
        }
    }
    else {
        $(obj).addClass("active");
    }
    if (page === 1) {
        $("#products-nav  li").first().addClass("disabled");
    }
    else if (page === amountOfPage) {
        $("#products-nav  li").last().addClass("disabled");
    }

}
function ChangePage(obj) {
    page = parseInt($(obj).first("a").text());
    PageNavigationUpdate();
    --page;
    LoadMealsOnPage();
}

function NextPage() {
    if (page < amountOfPage - 1) {
        page += 2;
        PageNavigationUpdate();
        --page;
        LoadMealsOnPage();
    }
}

function PrevPage() {
    if (page > 0) {
        PageNavigationUpdate();
        --page;
        LoadMealsOnPage();
    }
}

var page = 0;
var elemsPerPage = 20;

function LoadMealsOnPage() { // функція яка буде вішаться на подію загрузки сторінки
    GetMeals(page, elemsPerPage) // виклик моєї функції отримання списку страв із сервера з аргументами page і elemsPerPage
        .then(function (data) {
            console.log("Amount of meals:" + data.length); // тут пишеш що буде відбуватись якщо сервер поверне дані
            LoadProducts(data);
            // data - масив страв
        },
        function (error) {
            console.log("Smthng wrong "); // тут пишеш що буде відбуватись якщо сервер поверне помилку
            // error - код помилки
            // в цьому випадку можеш вивести на сторінку якийсь напис "Проблема зв'яку із сервером"
        });
}


function LoadProducts(data) {
    meals = data;
    $("#products-list").empty();
    for (let i = 0; i < meals.length; ++i) {
        var s = "<div class='col-xl-3 col-lg-4 col-md-6 col-sm-6 сol-12 product'>";
        s += "<div class='card'>";
        s += "<img src='" + meals[i].MealPicUrl + "' alt='" + data[i].Name + ".jpg' class='card-img-top product-image'>";
        s += "<div class='card-body'>";
        s += "<h2 class='card-title product-title'>";
        s += "<span class='product-name'>" + meals[i].Name + "</span>";
        s += "<span class='product-raiting'>" + meals[i].Raiting + "</span>";
        s += "</h2>";
        s += "<div class='product-description'>";
        s += "<ul class='ingridient-list'>";
        meals[i].Ingredients.forEach(function(item, j, arr) {
            s += "<li class='ingridient'><span href='#' data-toggle='tooltip' data-placement='bottom' title='" + item.Description + "'>" + item.Name + "</span></li>"
        });
        s += "</ul>";
        s += "<p class='card-text'>" + meals[i].Description + "</p></div>";
        s += "<span class='product-price'>" + meals[i].Price + "UAH</span>";
        s += "<a href='#' class='btn basket-btn' onclick='AddNewProductToBasket(this)'>Buy</a>";
        s += "</div>";
        s += "</div>";
        s += "</div>";
        $("#products-list").append(s);
    }
    $('[data-toggle="tooltip"]').tooltip();
}

function AddNewProductToBasket(obj)
{
    var o = $(obj).parent().parent();
    var n = $("#products-list .card").index($(obj).parent().parent());
    alert(meals[n].Name + " added to basket");
}
function loadMainProductList() {


   /* function LoadDefProd() {
        let s = "<div class='col-xl-2 col-lg-3 col-md-4 col-sm-6 сol-12 product'>";
        s += "<div class='card'>";
        s += "<div class='product-img-container'>";
        s += "<img src='" + "https://5.imimg.com/data5/PE/RX/MY-1489587/china-dish-500x500.jpg" + "' alt='" + "' class='card-img-top product-image'>";
        s += "</div>";
        s += "<div class='card-body'>";
        s += "<h2 class='card-title product-title'>";
        s += "<span class='product-name'>" + "Pizza" + "</span>";
        s += "<span class='product-raiting'>" + "4.6" + "</span>";
        s += "</h2>";
        s += "<p class='card-text product-description'>" + "Kind of best pizzas ever been, just awesome. Such good as it could be expected. Mmmmm, just perfect!" + "</p>";
        s += "<span class='product-price'>" + "125 UAH" + "</span>";
        s += "<a href='#' class='btn basket-btn' onclick='AddNewProductToMain()'>Buy</a>";
        s += "</div>";
        s += "</div>";
        s += "</div>";
        $("#products-list").append(s);
        s = "<div class='col-xl-2 col-lg-3 col-md-4 col-sm-6 сol-12 product'>";
        s += "<div class='card'>";
        s += "<div class='product-img-container'>";
        s += "<img src='" + "https://5.imimg.com/data5/PE/RX/MY-1489587/china-dish-500x500.jpg" + "' alt='" + "' class='card-img-top product-image'>";
        s += "</div>";
        s += "<div class='card-body'>";
        s += "<h2 class='card-title product-title'>";
        s += "<span class='product-name'>" + "Pizza" + "</span>";
        s += "<span class='product-raiting'>" + "4.6" + "</span>";
        s += "</h2>";
        s += "<p class='card-text product-description'>" + "Kind of best pizzas ever been, just awesome. Such good as it could be expected. Mmmmm, just perfect!" + "</p>";
        s += "<span class='product-price'>" + "125 UAH" + "</span>";
        s += "<a href='#' class='btn basket-btn' onclick='AddNewProductToMain()'>Buy</a>";
        s += "</div>";
        s += "</div>";
        s += "</div>";
        $("#products-list").append(s);
        s = "<div class='col-xl-2 col-lg-3 col-md-4 col-sm-6 сol-12 product'>";
        s += "<div class='card'>";
        s += "<div class='product-img-container'>";
        s += "<img src='" + "https://5.imimg.com/data5/PE/RX/MY-1489587/china-dish-500x500.jpg" + "' alt='" + "' class='card-img-top product-image'>";
        s += "</div>";
        s += "<div class='card-body'>";
        s += "<h2 class='card-title product-title'>";
        s += "<span class='product-name'>" + "Pizza" + "</span>";
        s += "<span class='product-raiting'>" + "4.6" + "</span>";
        s += "</h2>";
        s += "<p class='card-text product-description'>" + "Kind of best pizzas ever been, just awesome. Such good as it could be expected. Mmmmm, just perfect!" + "</p>";
        s += "<span class='product-price'>" + "125 UAH" + "</span>";
        s += "<a href='#' class='btn basket-btn' onclick='AddNewProductToMain()'>Buy</a>";
        s += "</div>";
        s += "</div>";
        s += "</div>";
        $("#products-list").append(s);
        s = "<div class='col-xl-2 col-lg-3 col-md-4 col-sm-6 сol-12 product'>";
        s += "<div class='card'>";
        s += "<div class='product-img-container'>";
        s += "<img src='" + "https://5.imimg.com/data5/PE/RX/MY-1489587/china-dish-500x500.jpg" + "' alt='" + "' class='card-img-top product-image'>";
        s += "</div>";
        s += "<div class='card-body'>";
        s += "<h2 class='card-title product-title'>";
        s += "<span class='product-name'>" + "Pizza" + "</span>";
        s += "<span class='product-raiting'>" + "4.6" + "</span>";
        s += "</h2>";
        s += "<p class='card-text product-description'>" + "Kind of best pizzas whj hjdf hg hdsf gjdsh gd ghdsl ghdsl ghdsj ghsdlhsdjhsdjg hdsjg hdsfjg hdsfl ghdsl hgdsl ghs lhdsl khds gksdh sdlk hgsl dhldk hsdlkh gdsjl ghsdl hdsl hl hgsdljg hsdjlghdsjl ghds hds ghldsfg hsdlj ghdsjl ghd d ever been, just awesome. Such good as it could be expected. Mmmmm, just perfect!" + "</p>";
        s += "<span class='product-price'>" + "125 UAH" + "</span>";
        s += "<a href='#' class='btn basket-btn' onclick='AddNewProductToMain()'>Buy</a>";
        s += "</div>";
        s += "</div>";
        s += "</div>";
        $("#products-list").append(s);
    }*/

    (function LoadPages() {
        if (amountOfPage < 15) {
            $("#products-nav ul").append("<li class='page-item disabled' onclick='PrevPage()'><a class='page-link' href='#'>Previous</a></li>");
            $("#products-nav ul").append("<li class='page-item active' onclick='ChangePage(this)'><a class='page-link' href='#'>1</a></li>");
            for (let i = 2; i <= amountOfPage; ++i) {
                $("#products-nav ul").append("<li class='page-item' onclick='ChangePage(this)'><a class='page-link' href='#'>" + i + "</a></li>");
            }
            $("#products-nav ul").append("<li class='page-item' onclick='NextPage()'><a class='page-link' href='#'>Next</a></li>");
        }
        else {
            $("#products-nav ul").append("<li class='page-item disabled' onclick='PrevPage()'><a class='page-link' href='#'>Previous</a></li>");
            for (let i = 1; i < 7; ++i) {
                $("<li class='page-item' onclick='ChangePage(this)'><a class='page-link' href='#'>" + i + "</a></li>").appendTo("#products-nav ul");
            }
            $("<li class='page-item'><a class='page-link' href='#'>...</a></li>").appendTo("#products-nav ul");
            $("<li class='page-item' onclick='ChangePage(this)'><a class='page-link' href='#'>" + amountOfPage + "</a></li>").appendTo("#products-nav ul");
            $("#products-nav  li:eq(1)").addClass("active");
            $("#products-nav ul").append("<li class='page-item' onclick='NextPage()'><a class='page-link' href='#'>Next</a></li>");
        }
        currPage = 1;
        LoadMealsOnPage();
    })();
}