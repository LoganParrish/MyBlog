$(document).ready(function(){
    $('.like').on('click', function () {
        var postId = $(this).data('postid');
        var theLikeButton = $(this);
        $.get('/Home/LikePost/' + postId, function (data) {
            theLikeButton.parent().html(data)
        });
    });

    $('.showComments').on('click', function(){
        var parent = $(this).parent();
        var commentsToDisplay = parent.find('.commentsDiv');
        commentsToDisplay.slideToggle();
    });
    //wiring up the Ajax Post for the comment form

    $('.commentsDiv form').on('submit', function (event) {
        event.preventDefault();
        var theForm = $(this);
        $.post(theForm.attr('action'), theForm.serialize(), function (data) {
            //update our html
            theForm.before(data);

            theForm.find('.commentAuthor, .commentBody').val('')
        });
    });
});