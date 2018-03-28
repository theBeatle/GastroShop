var $star_rating = $('.star-rating .fa');
var filter_visible = false;

var SetRatingStar = function () {
    return $star_rating.each(function () {
        if (parseInt($star_rating.siblings('input.rating-value').val()) >= parseInt($(this).data('rating'))) {
            return $(this).removeClass('fa-star-o').addClass('fa-star');
        } else {
            return $(this).removeClass('fa-star').addClass('fa-star-o');
        }
    });
};

$star_rating.on('click', function () {
    $star_rating.siblings('input.rating-value').val($(this).data('rating'));
    return SetRatingStar();
});

SetRatingStar();
$(document).ready(function () {

});

$(function () {
    $("#slider-range").slider({
        range: true,
        min: 0,
        max: 500,
        values: [75, 300],
        slide: function (event, ui) {
            $("#amount").val("$" + ui.values[0] + " - $" + ui.values[1]);
        }
    });


    $("#amount").val("$" + $("#slider-range").slider("values", 0) +
        " - $" + $("#slider-range").slider("values", 1));
});

function ShowOrHideFilter() {
    if (filter_visible) {
        $("#btn-filrer-show").css("display", "block");
    }
    else {
        $("#btn-filrer-show").css("display", "none");
    }
    filter_visible = !filter_visible;
}

function RemoveIngredient() {
    $(this).parent().parent().remove();
}

$(function () {
    $('add-ingredient').click(function () {
        var add_ingr = "<li class='list-group-item'" +
            "<div style='width: 100%; '>" +
                "<span style='width: 74%; display:inline-block;'>Cras jusretgre</span>" +
                "<button style='vertical-align:top; border-radius:10px; display:inline-block;' type='button' class='btn btn-outline-danger btn-sm'><b class='fa fa-close'></b></button>" +
            "</div>" +
        "</li>";

        //var additem = $(this).clone();
        //var coast = parseInt(additem.find('div.coast').html());
        //value += coast;
        //additem.click(function () {
        //    var removedcoast = parseInt(additem.find('div.coast').html());
        //    value -= removedcoast;
        //    $('span.value').html(value);
        //    $(this).remove();
        //})
        //$('#useditems').append(additem);
        //$('#useditems').find('div.handle').removeClass('handle').addClass('delete');
        //$('span.value').html(value);
    });
});