var currPage = 1;
var amountOfPage = 20;

function PageNavigationUpdate() {
    $("#products-nav li").removeClass("active").removeClass("disabled");
    if (amountOfPage > 15) {
        var curAm = $("#products-nav li").length;
        $("#products-nav li:eq(2)").nextUntil("#products-nav li:eq(" + (curAm - 2) + ")").remove();
        $("#products-nav li").removeClass("disabled");
        if (currPage > 4 && currPage < amountOfPage - 3) {
            $("<li class='page-item'><a class='page-link' href='#'>...</a></li>").insertAfter("#products-nav li:eq(2)");
            $("<li class='page-item' onclick='ChangePage(this)'><a class='page-link' href='#'>" + (currPage - 1) + "</a></li>").insertAfter("#products-nav li:eq(3)");
            $("<li class='page-item active'><a class='page-link' href='#'>" + currPage + "</a></li>").insertAfter("#products-nav li:eq(4)");
            $("<li class='page-item' onclick='ChangePage(this)'><a class='page-link' href='#'>" + (currPage + 1) + "</a></li>").insertAfter("#products-nav li:eq(5)");
            $("<li class='page-item'><a class='page-link' href='#'>...</a></li>").insertAfter("#products-nav li:eq(6)");
        }
        else if (currPage > 4) {
            $("<li class='page-item'><a class='page-link' href='#'>...</a></li>").insertAfter("#products-nav li:eq(2)");
            for (var i = amountOfPage - 6; i < amountOfPage; ++i) {
                $("<li class='page-item' onclick='ChangePage(this)'><a class='page-link' href='#'>" + i + "</a></li>").insertBefore("#products-nav li:not(#products-nav li:last):last");
            }
            curAm = $("li").length - 2;
            $("#products-nav li:eq(" + (curAm - (amountOfPage - currPage)) + ")").addClass("active");
        }
        else if (currPage < amountOfPage - 3) {
            for (var i = 3; i < 7; ++i) {
                $("<li class='page-item' onclick='ChangePage(this)'><a class='page-link' href='#'>" + i + "</a></li>").insertBefore("#products-nav li:not(#products-nav li:last):last");
            }
            $("<li class='page-item'><a class='page-link' href='#'>...</a></li>").insertBefore("#products-nav li:not(#products-nav li:last):last");
            $("#products-nav li:eq(" + currPage + ")").addClass("active");
        }
    }
    else {
        $(obj).addClass("active");
    }
    if (currPage == 1) {
        $("#products-nav  li").first().addClass("disabled");
    }
    else if (currPage == amountOfPage) {
        $("#products-nav  li").last().addClass("disabled");
    }

}
function ChangePage(obj) {
    currPage = parseInt($(obj).first("a").text());
    PageNavigationUpdate();
}

function NextPage() {
    if (currPage < amountOfPage) {
        ++currPage;
        PageNavigationUpdate();
    }
}

function PrevPage() {
    if (currPage > 1) {
        --currPage;
        PageNavigationUpdate();
    }
}

function AddNewProductToMain() {
    $("#products-list").empty();
    var s = "<div class='col-xl-2 col-lg-3 col-md-4 col-sm-6 сol-12 product'>";
    s += "<div class='card'>";
    s += "<div class='product-img-container'>";
    s += "<img src='" + "https://5.imimg.com/data5/PE/RX/MY-1489587/china-dish-500x500.jpg" + "' alt='" + "' class='card-img-top product-image'>";
    s += "</div>";
    s += "<div class='card-body'>";
    s += "<h2 class='card-title'>";
    s += "<span class='product-name'>" + "</span>";
    s += "<span class='product-raiting'>" + "</span>";
    s += "</h2>";
    s += "<p class='card-text'>" + "</p>";
    s += "<span class='product-price'>" + "</span>";
    s += "<a href='#' class='btn btn-dark basket-btn' onclick='AddNewProductToMain()'>Buy</a>";
    s += "</div>";
    s += "</div>";
    s += "</div>";
    $("#products-list").append(s);
}

function LoadPages() {
    if (amountOfPage < 15) {
        $("#products-nav ul").append("<li class='page-item disabled' onclick='PrevPage()'><a class='page-link' href='#'>Previous</a></li>");
        $("#products-nav ul").append("<li class='page-item active' onclick='ChangePage(this)'><a class='page-link' href='#'>1</a></li>");
        for (var i = 2; i <= amountOfPage; ++i) {
            $("#products-nav ul").append("<li class='page-item' onclick='ChangePage(this)'><a class='page-link' href='#'>" + i + "</a></li>");
        }
        $("#products-nav ul").append("<li class='page-item' onclick='NextPage()'><a class='page-link' href='#'>Next</a></li>");
    }
    else {
        $("#products-nav ul").append("<li class='page-item disabled' onclick='PrevPage()'><a class='page-link' href='#'>Previous</a></li>");
        for (var i = 1; i < 7; ++i) {
            $("<li class='page-item' onclick='ChangePage(this)'><a class='page-link' href='#'>" + i + "</a></li>").appendTo("#products-nav ul");
        }
        $("<li class='page-item'><a class='page-link' href='#'>...</a></li>").appendTo("#products-nav ul");
        $("<li class='page-item' onclick='ChangePage(this)'><a class='page-link' href='#'>" + amountOfPage + "</a></li>").appendTo("#products-nav ul");
        $("#products-nav  li:eq(1)").addClass("active");
        $("#products-nav ul").append("<li class='page-item' onclick='NextPage()'><a class='page-link' href='#'>Next</a></li>");
    }
    currPage = 1;
    LoadDefProd();
    /*
             <li class="page-item"><a class="page-link" href="#">Previous</a></li>
             <li class="page-item"><a class="page-link" href="#" onclick="ChangePage(this)">1</a></li>
             <li class="page-item"><a class="page-link" href="#" onclick="ChangePage(this)">2</a></li>
             <li class="page-item"><a class="page-link" href="#" onclick="ChangePage(this)">3</a></li>
             <li class="page-item"><a class="page-link" href="#">Next</a></li>
     */
}

function LoadDefProd()
{
    var s = "<div class='col-xl-2 col-lg-3 col-md-4 col-sm-6 сol-12 product'>";
    s += "<div class='card'>";
    s += "<div class='product-img-container'>";
    s += "<img src='" + "https://5.imimg.com/data5/PE/RX/MY-1489587/china-dish-500x500.jpg" + "' alt='" + "' class='card-img-top product-image'>";
    s += "</div>";
    s += "<div class='card-body'>";
    s += "<h2 class='card-title'>";
    s += "<span class='product-name'>" + "Pizza"+ "</span>";
    s += "<span class='product-raiting'>" +"4.6"+ "</span>";
    s += "</h2>";
    s += "<p class='card-text'>" + "Kind of best pizzas ever been, just awesome. Such good as it could be expected. Mmmmm, just perfect!" +"</p>";
    s += "<span class='product-price'>" +"125"+ "</span>";
    s += "<a href='#' class='btn btn-dark basket-btn' onclick='AddNewProductToMain()'>Buy</a>";
    s += "</div>";
    s += "</div>";
    s += "</div>";
    $("#products-list").append(s);
    var s = "<div class='col-xl-2 col-lg-3 col-md-4 col-sm-6 сol-12 product'>";
    s += "<div class='card'>";
    s += "<div class='product-img-container'>";
    s += "<img src='" + "https://5.imimg.com/data5/PE/RX/MY-1489587/china-dish-500x500.jpg" + "' alt='" + "' class='card-img-top product-image'>";
    s += "</div>";
    s += "<div class='card-body'>";
    s += "<h2 class='card-title'>";
    s += "<span class='product-name'>" + "Pizza" + "</span>";
    s += "<span class='product-raiting'>" + "4.6" + "</span>";
    s += "</h2>";
    s += "<p class='card-text'>" + "Kind of best pizzas ever been, just awesome. Such good as it could be expected. Mmmmm, just perfect!" + "</p>";
    s += "<span class='product-price'>" + "125" + "</span>";
    s += "<a href='#' class='btn btn-dark basket-btn' onclick='AddNewProductToMain()'>Buy</a>";
    s += "</div>";
    s += "</div>";
    s += "</div>";
    $("#products-list").append(s);
    var s = "<div class='col-xl-2 col-lg-3 col-md-4 col-sm-6 сol-12 product'>";
    s += "<div class='card'>";
    s += "<div class='product-img-container'>";
    s += "<img src='" + "https://5.imimg.com/data5/PE/RX/MY-1489587/china-dish-500x500.jpg" + "' alt='" + "' class='card-img-top product-image'>";
    s += "</div>";
    s += "<div class='card-body'>";
    s += "<h2 class='card-title'>";
    s += "<span class='product-name'>" + "Pizza" + "</span>";
    s += "<span class='product-raiting'>" + "4.6" + "</span>";
    s += "</h2>";
    s += "<p class='card-text'>" + "Kind of best pizzas ever been, just awesome. Such good as it could be expected. Mmmmm, just perfect!" + "</p>";
    s += "<span class='product-price'>" + "125" + "</span>";
    s += "<a href='#' class='btn btn-dark basket-btn' onclick='AddNewProductToMain()'>Buy</a>";
    s += "</div>";
    s += "</div>";
    s += "</div>";
    $("#products-list").append(s);
    var s = "<div class='col-xl-2 col-lg-3 col-md-4 col-sm-6 сol-12 product'>";
    s += "<div class='card'>";
    s += "<div class='product-img-container'>";
    s += "<img src='" + "https://5.imimg.com/data5/PE/RX/MY-1489587/china-dish-500x500.jpg" + "' alt='" + "' class='card-img-top product-image'>";
    s += "</div>";
    s += "<div class='card-body'>";
    s += "<h2 class='card-title'>";
    s += "<span class='product-name'>" + "Pizza" + "</span>";
    s += "<span class='product-raiting'>" + "4.6" + "</span>";
    s += "</h2>";
    s += "<p class='card-text'>" + "Kind of best pizzas ever been, just awesome. Such good as it could be expected. Mmmmm, just perfect!" + "</p>";
    s += "<span class='product-price'>" + "125" + "</span>";
    s += "<a href='#' class='btn btn-dark basket-btn' onclick='AddNewProductToMain()'>Buy</a>";
    s += "</div>";
    s += "</div>";
    s += "</div>";
    $("#products-list").append(s);
}