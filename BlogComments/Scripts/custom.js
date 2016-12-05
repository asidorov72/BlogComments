
/*
function visible(elm) {
    if (!elm.offsetHeight && !elm.offsetWidth) { return false; }
    if (getComputedStyle(elm).visibility === 'hidden') { return false; }
    return true;
}

function setCollapseExpandIcon(postId) {
    
    var CommentsBoxSelector = document.getElementById('ajaxResultComments_' + postId);
    
    if (visible(CommentsBoxSelector) === true) {
        document.getElementById('expandCollapseIcon_' + postId).innerHTML = "lesshtml";
    } else {
        document.getElementById('expandCollapseIcon_' + postId).innerHTML = "morehtml";
    }
};
*/

jQuery(document).ready(function ($) {

    var showChar = 250;  // How many characters are shown by default
    var ellipsestext = '';
    var moretext = '<i class="fa fa-plus-square-o" aria-hidden="true"></i>';
    var lesstext = '<i class="fa fa-minus-square-o" aria-hidden="true"></i>';

    /*
    $.setCollapseExpandIcon = (function (postId) {

        var CommentsBoxSelector = $('#ajaxResultComments_' + postId);

        Console.log('Is Visible: ' + $(CommentsBoxSelector).is(':visible'));
        Console.log(lesstext);

        if ($(CommentsBoxSelector).is(':visible')) {
            $('#expandCollapseIcon_' + postId).html("lesshtml");
        } else {
            $('#expandCollapseIcon_' + postId).html("morehtml");
        }
    });
    */


    $('.more').each(function () {
        var content = $(this).html();

        if (content.length > showChar) {

            var c = content.substr(0, showChar);
            var h = content.substr(showChar, content.length - showChar);
            var html = c + '<span class="moreellipses">' + ellipsestext + '&nbsp;</span><span class="morecontent"><span>' + h + '</span>&nbsp;<a href="" class="morelink">' + moretext + '</a></span>';

            $(this).html(html);
        }
    });

    $(".morelink").click(function () {
        if ($(this).hasClass("less")) {
            $(this).removeClass("less");
            $(this).html(moretext);
        } else {
            $(this).addClass("less");
            $(this).html(lesstext);
        }
        
        $(this).parent().prev().toggle(
            function() {
                $(this).animate({ }, 800);
            });

        $(this).prev().toggle(function () {
                $(this).animate({}, 800);
            });

        return false;
    });

    $('.morecomments').each(function () {
        var content = $(this).html(moretext);
    });

    $(".ShowCommentsBtn").click(function () {
        if ($('.morecomments', this).hasClass("less")) {
            $('.morecomments', this).removeClass("less");
            $('.morecomments', this).html(moretext);
        } else {
            $('.morecomments', this).addClass("less");
            $('.morecomments', this).html(lesstext);
        }
    });



    $(".AddCommentBtn").click(function (event) {
        event.preventDefault();

        var PostIdParam = $(this).attr('href').match(/PostId=([0-9]+)/)[1];
        $('#addCommentForm_' + PostIdParam).fadeIn("fast", function () {
            $(this).show();
        });

        return false;
    });




    $(".AddCommentCloseBtn").click(function (event) {
        event.preventDefault();
        var AddCommentFormWrapperId = $(this).closest('div.addCommentForm').attr('id');
        $('#' + AddCommentFormWrapperId).fadeOut("fast", function () {
            $(this).hide();
        });
    });



    $.updatesCommentsCounter = (function (comentsCount, postId) {
        $('#commentsCount_' + postId).html(comentsCount);

        var CommentsBoxSelector = $('#ajaxResultComments_' + postId);
        var className = $(CommentsBoxSelector).attr('class');

        //Console.log('Before: ' + $(CommentsBoxSelector).is(':visible'));

        if ($(CommentsBoxSelector).is(':visible')) {
            $('#ajaxResultComments_' + postId + ' .' + className).css('display', 'block');
        } else {
            $('#ajaxResultComments_' + postId + ' .' + className).css('display', 'none');
        }
        setCollapseExpandIcon(postId);
    });



    $(".ShowCommentsBtn").click(function (event) {
        event.preventDefault();

        var PostIdParam = $(this).attr('href').match(/PostId=([0-9]+)/)[1];
        var CommentsBoxSelector = $('#ajaxResultComments_' + PostIdParam);
        var className = $(CommentsBoxSelector).attr('class');

        if ($(CommentsBoxSelector).is(':visible')) {
            $(CommentsBoxSelector).fadeOut("fast", function () {
                $('#ajaxResultComments_' + PostIdParam + ' .' + className).css('display', 'none');
                $(this).css('display', 'none');
            });
           
        } else {
            $(CommentsBoxSelector).fadeIn("fast", function () {
                $('#ajaxResultComments_' + PostIdParam + ' .' + className).css('display', 'block');
                $(this).css('display', 'block');
            });
        }
        return false;  
    });




    
});