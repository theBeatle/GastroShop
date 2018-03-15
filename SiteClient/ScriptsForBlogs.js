window.addEventListener('load', function () {

    document.getElementById('btnShowAllCommetns').addEventListener('click', AddDivIncomments);
});

var x = 0; var flagForIsShowComments = false; var flagForClickPutGradeBTN = false;

function AddCommentBlock()
{
    document.getElementById('styleAdditionWindow').style.display = 'block';
    document.getElementById('styleAddWinwrap').style.display = 'block';
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
    RemoveDivAddBlog();
    document.getElementById('BlogDivId').style.display = 'block';
}

function RemoveBlogDiv()
{
    document.getElementById('BlogDivId').style.display = 'none';
}

function RemoveDivAddBlog()
{
    document.getElementById('divAddBlog').style.display = 'none';
}

function ShowDivAddBlog()
{
    RemoveBlogDiv();
    var divGradePut = document.getElementById('DivPutGrade');

    divGradePut.innerHTML = '';

    flagForClickPutGradeBTN = false;

    document.getElementById('divAddBlog').style.display = 'block';
}


function ShowDivPutTheGrade()
{
    if (flagForClickPutGradeBTN == false)
    {
        flagForClickPutGradeBTN = true;
        var divGradePut = document.getElementById('DivPutGrade');

        divGradePut.innerHTML += "<br><br><p style='font-size:20px'><b>The reviewer's assessment helps determine his karma(to some extent, this is an indicator of how much you can trust him)</b></p>";

        divGradePut.innerHTML += "<br><div class='form-group'><label for='selectGradeId'><b>Select grade:</b></label><select class='form-control' style='width:15%' id='selectGradeId'><option>1</option><option>2</option><option>3</option><option>4</option><option>5</option></select></div>";

        divGradePut.innerHTML += "<button style='width:15%;font-size:20px' class='btn btn-outline-primary'>Put</button><br><br>"
    }
}

function ShowComments()
{
    if (flagForIsShowComments == false)
    {
        var BlogDiv = document.getElementById('BlogDivId');

        BlogDiv.innerHTML += "<br><br><h4 class='text-center text-primary'>C o m m e n t s</h4>";



        var divComment = document.createElement('div');

        var pAuthoreOfTheComment = document.createElement('p');

        pAuthoreOfTheComment.id = 'authoreIdWhichAddedTheComment';

        pAuthoreOfTheComment.style.fontWeight = 'bold';

        pAuthoreOfTheComment.textContent = 'Empty name';

        divComment.appendChild(pAuthoreOfTheComment);



        var pCommenText = document.createElement('p');

        pCommenText.id = 'CommentTextId';

        pCommenText.className = 'form-group';

        pCommenText.style.display = 'initial';

        pCommenText.readOnly = true;

        pCommenText.style.border = '0px'

        pCommenText.style.backgroundColor = 'lightGray';

        pCommenText.style.borderRadius = '7px';

        pCommenText.textContent = 'Empty text';

        
        divComment.appendChild(pCommenText);




        BlogDivId.appendChild(divComment);

        BlogDiv.innerHTML += '<br>';

        flagForIsShowComments = true;

        document.getElementById('ShowCommentsForThisReviewId').title = 'Comments is added';    
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

        createDiv.title = 'Read review';


        var pDataOfAdded = document.createElement('p');




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

        pText.textContent = 'Review theme: ';

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