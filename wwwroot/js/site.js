// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function toggleDetails(id) {
    var button = document.getElementById("btn-details#"+id);
    if (button.value == "More Details") {
        button.value = "Less Details";
    }
    else {
        button.value = "More Details";
    }
}

$("document").ready(function () {
    $('[data-toggle="tooltip"]').tooltip()
});