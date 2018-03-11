window.addEventListener('load', function () {

    document.getElementById('btnShowAllCommetns').addEventListener('click', AddDivIncomments);


});

var x = 0;

function AddDivIncomments()
{
        var createDiv = document.createElement('div');

        createDiv.style.width = '90%';

        createDiv.style.height = '24vh';

        createDiv.style.backgroundColor = 'green';

        createDiv.className = 'border';

        createDiv.className = 'border-danger';

        createDiv.className = 'block';

        createDiv.style.margin = '0 auto';

        createDiv.style.marginTop = '3%'; createDiv.style.marginBottom = '3%';

        createDiv.textContent = 'text' + x;

        divForShowingComments.appendChild(createDiv);
   
        x++;
}