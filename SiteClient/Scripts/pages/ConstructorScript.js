var value = 0;
$(function () {
    $('#myTab a:last').tab('show')
});
$(function () {
    $('li').click(function () {
        var additem = $(this).clone();
        var coast = parseInt(additem.find('div.coast').html());
        value += coast;
        additem.click(function () {
        var removedcoast = parseInt(additem.find('div.coast').html());
        value -= removedcoast;
        $('span.value').html(value);
        $(this).remove();
        })
        $('#useditems').append(additem);
        $('#useditems').find('div.handle').removeClass('handle').addClass('delete');
        $('span.value').html(value);
    });
});