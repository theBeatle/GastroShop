window.addEventListener('load', function () {

    document.getElementById('btnShowAllCommetns').addEventListener('click', AddDivIncomments);
});

var x = 0; var flagForIsShowComments = false;

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

function ShowBlogDiv()
{

}

function ShowComments()
{
    if (flagForIsShowComments == false) {
        var BlogDiv = document.getElementById('BlogDivId');

        BlogDiv.innerHTML += "<h4 class='text-center text-info'>C o m m e n t s</h4>";



        var divComment = document.createElement('div');

        var pAuthoreOfTheComment = document.createElement('p');

        pAuthoreOfTheComment.id = 'authoreIdWhichAddedTheComment';

        pAuthoreOfTheComment.textContent = 'Empty name';

        divComment.appendChild(pAuthoreOfTheComment);



        var pCommenText = document.createElement('p');

        pCommenText.id = 'CommentTextId';

        pCommenText.textContent = 'empty text';

        divComment.style.border = '2px solid';

        divComment.className = 'border-info';

        divComment.style.borderRadius = '3px';

        divComment.appendChild(pCommenText);




        BlogDivId.appendChild(divComment);

        BlogDiv.innerHTML += '<br>';
    }
}

function AddDivIncomments()
{
    for (var i = 0; i < 3; i++)
    {
        var createDiv = document.createElement('div');

        createDiv.style.width = '90%';

        createDiv.style.height = '24vh';

        createDiv.style.border = '2px solid';

        createDiv.style.borderRadius = '5px';

        createDiv.style.border = 'none';

        createDiv.style.margin = '0 auto';

        createDiv.style.marginTop = '3%'; createDiv.style.marginBottom = '3%';

        createDiv.style.opacity = "0.8";

        createDiv.style.backgroundColor = 'white';

        createDiv.style.cursor = 'pointer';

        createDiv.addEventListener('click', ShowBlogDiv);



        var hTitle = document.createElement('h3');

        hTitle.className = 'text-success';

        hTitle.textContent = 'R e v i e w';

        createDiv.appendChild(hTitle);



        var pAuthor = document.createElement('p');

        pAuthor.textContent = 'Author: ' + x;

        pAuthor.style.marginLeft = '1%';

        createDiv.appendChild(pAuthor);



        var pProdReview = document.createElement('p');

        pProdReview.textContent = 'Product review: ' + x;

        pProdReview.style.marginLeft = '1%';

        createDiv.appendChild(pProdReview);



        var pText = document.createElement('p');

        pText.textContent = 'Review description: ';

        pText.style.marginLeft = '1%';

        createDiv.appendChild(pText);




        //var btnAddCommentD = document.createElement('button');

        //btnAddCommentD.style.width = '40%';

        ////btnAddCommentD.style.marginTop = '20%';

        //btnAddCommentD.style.height = '20%';

        //btnAddCommentD.style.cssFloat = 'right';

        //btnAddCommentD.style.marginRight = '5%';

        //btnAddCommentD.style.borderRadius = '5px';

        //btnAddCommentD.style.fontSize = '15px';

        //btnAddCommentD.className = 'btn';

        //btnAddCommentD.className = 'btn-outline-dark';

        //btnAddCommentD.textContent = 'Add comment';

        //btnAddCommentD.style.cursor = 'pointer';

        //createDiv.appendChild(btnAddCommentD);

        //btnAddCommentD.addEventListener('click', AddCommentBlock);




        divForShowingComments.appendChild(createDiv);

        x++;
    }
}