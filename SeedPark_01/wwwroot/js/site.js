

$(document).ready(function () {

    //navbar scroll from starting point to fixed position at the top of the screen
    var navBar = $('.navbar');
    var navOffset = navBar.offset().top;

    function scroll() {
        if ($(window).scrollTop() >= navOffset) {
            $('.navbar').addClass('navbar-fixed-top');
        } else {
            $('.navbar').removeClass('navbar-fixed-top');
        }
    }
    document.onscroll = scroll;
    //END - navbar scroll

    //using slick to make an image carousel that has a hidden overflow on the x-axis
    $('.slick-multiple-items').slick({
        infinite: true,
        slidesToShow: 3,
        slidesToScroll: 3
    });

    $('.slick-responsive').slick({
        dots: false,
        infinite: true,
        speed: 300,
        slidesToShow: 4,
        slidesToScroll: 4,
        responsive: [
            {
                breakpoint: 992,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 3
                }
            },
            {
                breakpoint: 768,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
            // You can unslick at a given breakpoint now by adding:
            // settings: "unslick"
            // instead of a settings object
        ]
    });
    //END - slick carousel settings

    //////////////Custom carousel controls - BEGIN/////////////
    $('#myCarousel').carousel({
        interval: 5000
    });

    $('#carousel-text').html($('#slide-content-0').html());

    //Handles the carousel thumbnails
    $('[id^=carousel-selector-]').click(function () {
        var id_selector = $(this).attr("id");
        var id = id_selector.substr(id_selector.length - 1);
        var id = parseInt(id);
        $('#myCarousel').carousel(id);
    });

    // When the carousel slides, auto update the text
    $('#myCarousel').on('slid', function (e) {
        var id = $('.item.active').data('slide-number');
        $('#carousel-text').html($('#slide-content-' + id).html());
    });
    //////////////Custom carousel controls - END/////////////
});