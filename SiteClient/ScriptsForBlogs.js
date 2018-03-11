window.addEventListener('load', function () {

    document.getElementById('btnShowAllCommetns').addEventListener('click', ShowAllComments);
});

var x = 0;

function AddComment(state)
{
    document.getElementById('styleAdditionWindow').style.display = state;
    document.getElementById('styleAddWinwrap').style.display = state;
}

function ShowAllComments()
{
    window.location = 'AllBlogs.html';
}

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



    var pAuthor = document.createElement('p');

    pAuthor.textContent = 'Author: ' + x;

    pAuthor.style.marginLeft = '1%';

    createDiv.appendChild(pAuthor);



    var pComment = document.createElement('p');

    pComment.textContent = 'Comment: ' + x;

    pComment.style.marginLeft = '1%';

    createDiv.appendChild(pComment);



    divForShowingComments.appendChild(createDiv);
   
    x++;
}