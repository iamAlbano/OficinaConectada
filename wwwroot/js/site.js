// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function home() {
    var element = document.querySelector(".background");
    element.scrollIntoView();
}

function contact() {
    var element = document.querySelector(".contato");
    element.scrollIntoView();
}

window.onscroll = function () { navbar() };

function navbar() {

    if (document.body.scrollTop > 100 && document.body.scrollTop <= 700 || document.documentElement.scrollTop > 100 && document.documentElement.scrollTop <= 700) {
        $("#top-menu").removeClass('transparent');
        $("#top-menu").removeClass('colored');
        $("#top-menu").addClass('translucent');

    } else if (document.body.scrollTop > 700 || document.documentElement.scrollTop > 700) {
        $("#top-menu").removeClass('translucent');
        $("#top-menu").removeClass('transparent');
        $("#top-menu").addClass('colored');

    } else  {
        $("#top-menu").removeClass('colored');
        $("#top-menu").removeClass('translucent');
        $("#top-menu").addClass('transparent');
    }
};