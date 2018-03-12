window.addEventListener('load', function () {

    document.getElementById('btnShowAllCommetns').addEventListener('click', AddDivIncomments);
});

var x = 0;

function AddCommentBlock()
{
    document.getElementById('styleAdditionWindow').style.display = 'block';
    document.getElementById('styleAddWinwrap').style.display = 'block';
    document.getElementById('inputComments').value = '';
}


function AddCommentNone()
{
    document.getElementById('styleAdditionWindow').style.display = 'none';
    document.getElementById('styleAddWinwrap').style.display = 'none';
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



    var btnAddCommentD = document.createElement('button');

    btnAddCommentD.style.width = '35%';

    btnAddCommentD.style.marginTop = '20%';

    btnAddCommentD.id = 'btnAddCommentIntoBlog'

    btnAddCommentD.style.height = '25%';

    btnAddCommentD.style.cssFloat = 'right';

    btnAddCommentD.style.marginRight = '5%';

    btnAddCommentD.style.borderRadius = '5px';

    btnAddCommentD.style.fontSize = '18px';

    btnAddCommentD.className = 'btn';

    btnAddCommentD.className = 'btn-outline-warning';

    btnAddCommentD.textContent = 'Add comment';

    btnAddCommentD.style.cursor = 'pointer';

    createDiv.appendChild(btnAddCommentD);

    btnAddCommentD.addEventListener('click', AddCommentBlock);

    divForShowingComments.appendChild(createDiv);

    x++;
}