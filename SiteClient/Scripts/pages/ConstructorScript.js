//var categories = ["Chees", "Vegetables"];

var value = 0;
//function loadDoc() {
//    var xhttp = new XMLHttpRequest();
//    xhttp.onreadystatechange = function () {
//        if (this.readyState == 4 && this.status == 200) {
//            categories = this.responseText;
//        }
//    };
//    xhttp.open("POST", , true);
//    xhttp.send();
//};
//loadDoc();
function constructorLoad(categories) {
    var categories = categories;
    for (var i = 0; i < categories.length; i++) {
        loaded += "<div class=form-group><div class=titlemiddle><h4>" +++/*+ categories[i] +*/ "</h4></div>";
        loaded += "<div class=listwrapper>";
        loaded += "<ul class=pz-items>";
        //for (var j = 0; j < categories[i].ingredients.length; j++)
        //{
        //    loaded += "<li class=pz-item><div class=handle></div><div class=title>" + categories[i].ingredients[j].name + "</div> <div class=coast>" + categories[i].ingredients[j].price + "</div></li>";
        //}
        loaded += "</ul></div></div>";
    }
    $('#rightform').append(loaded);
}; 
$(function AddBehavior () {
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
$('#ConstructorBucket').click(function () {
    if (value > 0) {

        var newobject = ["CustomerConstructed", value.toString(), ("" + 1)];

        mass.push(newobject);
        $('#useditems').empty();
        value = 0;
        $('#spanValue').html(value);
        $('#Constructor').modal('hide');
        $('#quantityInIconCart').html(mass.length);
        $("#cartLinkModal").css("display", "inline-block");

    }
});

function LoadMealsOnPage() { // функція яка буде вішаться на подію загрузки сторінки
    GetMealsForConstructor() // виклик моєї функції отримання списку страв із сервера з аргументами page і elemsPerPage
        .then(function (data) {
            alert(data.length);
            constructorLoad(data);
            AddBehavior();
            console.log(data); // тут пишеш що буде відбуватись якщо сервер поверне дані
          
            // data - масив страв
        },
            function (error) {
                console.log(error); // тут пишеш що буде відбуватись якщо сервер поверне помилку
                // error - код помилки
                // в цьому випадку можеш вивести на сторінку якийсь напис "Проблема зв'яку із сервером"
            });
}