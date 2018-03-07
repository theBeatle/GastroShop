$(function () {
    $('#myTab a:last').tab('show')
});
$(function () {
    $('li').click(function () {
        var additem = $(this).clone();
        additem.click(function () {
            $(this).remove();
        })
        $('#useditems').append(additem);
    });
});