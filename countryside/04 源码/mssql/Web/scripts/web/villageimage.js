$(function () {
    $(".topNavigation").hide();

    var galleries = $('.ad-gallery').adGallery();
    galleries[0].settings.effect = "slide-vert";
});