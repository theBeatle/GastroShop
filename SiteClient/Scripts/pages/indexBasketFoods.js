var massHeaders = ["№", "Image", "Item", "Unit Price", "Quantity", "Price", "Remove"];
var massHeadersWidths = ["5%", "30%", "20%", "15%", "15%", "15%"];

var mass = [["OG Air Max 93", "109.50", "1"], ["AIR MAX 1", "134.00", "2"], ["Jordan 12", "157.00", "1"], ["Jordan 8", "221.00", "3"]];

var inputMass = mass;

$(function () {

    $("#quantityInCart").text(inputMass.length + " items");

    var table = $("<table></table>");
    table.attr({ "id": "tableCart", "border-collapse": "collapsed"});
    table.addClass("table table-bordered");

    var trow = $("<tr></tr>");

    var t = "";
    for (var i = 0; i < massHeaders.length; i++) {
        t = $("<th>" + massHeaders[i] + "</th>");
        t.attr({ "width": massHeadersWidths[i], "height": "80px", "text-align": "center" });
        trow.append(t);
    }
    table.append(trow);
    var totalTemp = 0.0;

    for (var j = 0; j < inputMass.length; j++) {
        var tdrow = $("<tr></tr>");
        for (var i = 0; i < massHeaders.length; i++) {
            switch (massHeaders[i]) {
                case "№":
                    td = $("<td>" + (j + 1) + "</td>");
                    break;
                case "Image":
                    td = $("<td>" + "NONAME" + "</td>");
                    break;
                case "Item":
                    td = $("<td>" + inputMass[j][0] + "</td>");
                    break;
                case "Unit Price":
                    td = $("<td>" + inputMass[j][1] + "</td>");
                    break;
                case "Quantity":
                    td = $("<td></td>");
                    var tabl = $("<table></table>");
                    table.addClass("innerTableQuantityCart");
                    var tr = $("<tr></tr>");
                    tr.attr("width", "100%");

                    var tdd = $("<td></td>");
                    tdd.attr("width", "35%");
                    var buttonMinus = $("<button></button>")
                    buttonMinus.addClass("btn btn-default fa fa-minus");
                    buttonMinus.attr({ "data-value": "decrease", "data-target": "#spinner" + (j + 1), "data-toggle": "spinner"});
                    buttonMinus.on("click", moreLessQuantity);
                    
                    tdd.append(buttonMinus);
                    tr.append(tdd);

                    tdd = $("<td></td>");
                    tdd.attr("width", "30%");
                    var input = $("<input></input>");
                    input.addClass("form-control input-number");
                    input.attr({ "type": "text", "data-ride": "spinner", "id": "spinner" + (j + 1), "value": inputMass[j][2], "width": "40px" });
                    tdd.append(input);

                    tr.append(tdd);

                    tdd = $("<td></td>");
                    tdd.attr("width", "35%");
                    var buttonPlus = $("<button></button>");
                    buttonPlus.addClass("btn btn-default fa fa-plus");
                    buttonPlus.attr({ "data-value": "increase", "data-target": "#spinner" + (j + 1), "data-toggle": "spinner" })
                    buttonPlus.on("click", moreLessQuantity);

                    tdd.append(buttonPlus);
                    tr.append(tdd);

                    tabl.append(tr);

                    td.append(tabl);
                    break;
                case "Price":
                    var pr = (inputMass[j][1] * inputMass[j][2]).toFixed(2);
                    totalTemp += parseFloat(pr);
                    td = $("<td>" + pr + "</td>");
                    td.addClass("data-price");
                    break;
                case "Remove":
                    td = $("<td></td>");
                    var button = $("<btn></btn>");
                    button.addClass("fa fa-trash fa-2x");
                    button.on("click", removeProduct);
                    td.append(button);
                    break;
            }
            tdrow.append(td);
        }
        table.append(tdrow);
    }

    $(".btn-number").on("click", moreLessQuantity);
    $("#checkOut").onclick = checkout;

    trow = $("<tr></tr>");
    for (var i = 0; i < massHeaders.length; i++) {
        var tddd = $("<td></td>");
        if (i == 0) {
            tddd.text("Total:");
            tddd.attr({ "colspan": 5 });
        }
        else if (i == massHeaders.length - 1) {
            tddd.addClass("data-total");
            tddd.last().text(totalTemp);
        }
        else
            continue;
        trow.append(tddd);
    }

    table.append(trow);

    $("#modalBody").append(table);
});

function moreLessQuantity() {
    var action = $(this).attr("data-value");
    switch (action) {
        case "decrease":
            var input = $(this).parent().next().children().first();
            var value = parseInt(input.val());
            if (value > 1) {
                input.val(--value);
                recountValues($(this), value);
            }
            break;
        case "increase":
            var input = $(this).parent().prev().children().first();
            var value = parseInt(input.val());
            input.val(++value);
            recountValues($(this), value);
            break;
    }
};

function recountValues(elem, quantity) {
    var unitPrice = elem.parent().parent().parent().parent().prev().text();
    var price = (parseFloat(unitPrice) * quantity).toFixed(2);

    elem.parent().parent().parent().parent().next().text(price);

    var total = countAllPrices();

    $(".data-total").text(total.toFixed(2));
}

function countAllPrices() {
    var total = 0.0;
    $(".data-price").each(function () {
        total += parseFloat($(this).text());
    });

    return total;
}

function removeProduct() {
    var tr = $(this).parent().parent();
    var index = tr.index();

    var deletedPrice = parseFloat($(this).parent().prev().text());
    var totalPrice = parseFloat($(".data-total").text());

    $(".data-total").text(totalPrice - deletedPrice);

    var temp = $(this).parent().parent().remove();

    delete inputMass[index - 1];

    var k = 1;
    var trr = $("#tableCart > tr").find("td:first");
    for (var i = 0; i < trr.length - 1; i++) {
        trr[i].innerText = k++;
    }
}


function checkout() {
    alert('checkout');
}
