function increaseLikeCount(postId) {
    $.post("/Post/IncreaseLikeCount", { postId: postId }, function (data) {
        if (data.success) {
            var likeCount = parseInt($("#LikeButton__" + postId).text());
            $("#LikeButton__" + postId).text(likeCount + 1);
        }
    });
}

function increaseMiddleLikeCount(postId) {
    $.post("/Post/IncreaseMiddleLikeCount", { postId: postId }, function (data) {
        if (data.success) {
            var middleLikeCount = parseInt($("#MiddleLikeButton__" + postId).text());
            $("#MiddleLikeButton__" + postId).text(middleLikeCount + 1);
        }
    });
}

function increaseDislikeCount(postId) {
    $.post("/Post/IncreaseDislikeCount", { postId: postId }, function (data) {
        if (data.success) {
            var dislikeCount = parseInt($("#DislikeButton__" + postId).text());
            $("#DislikeButton__" + postId).text(dislikeCount + 1);
        }
    });
}
