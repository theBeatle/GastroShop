var categories = ["Chees", "Vegetables"];
var value = 0;
function loadDoc() {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            categories = this.responseText;
        }
    };
    xhttp.open("POST", , true);
    xhttp.send();
};
loadDoc();
(function constructorLoad() {
    var loaded = "";
    for (var i = 0; i < categories.length; i++) {
        loaded += "<div class=form-group><div class=titlemiddle><h4>" + categories[i] + "</h4></div>";
        loaded += "<div class=listwrapper>";
        loaded += "<ul class=pz-items>";
        //for (var j = 0; j < categories[i].ingredients.length; j++)
        //{
        //    loaded += "<li class=pz-item><div class=handle></div><div class=title>" + categories[i].ingredients[j].name + "</div> <div class=coast>" + categories[i].ingredients[j].price + "</div></li>";
        //}
        loaded += "</ul></div></div>"
    }
    $('#rightform').append(loaded);
  
})(); 
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
        });
        $('#useditems').append(additem);
        $('#useditems').find('div.handle').removeClass('handle').addClass('delete');
        $('span.value').html(value);
    });
});