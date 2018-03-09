$(function () {
    $('#myTab a:last').tab('show');

    $('li').click(function () {
        var additem = $(this).clone();
        additem.click(function() {
            $(this).remove();
        });
        $('#useditems').append(additem);
    });
});