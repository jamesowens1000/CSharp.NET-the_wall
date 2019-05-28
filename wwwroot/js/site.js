// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var initVal = "";
$(document).ready(function(){
    $("#msgBtn").attr("disabled", "true");
    $("#msgText").keyup(function(){
        if ($(this).val() != initVal) {
            $("#msgBtn").removeAttr("disabled");
        } else {
            $("#msgBtn").attr("disabled", "true");
        }
    });
});
$(document).ready(function(){
    $(".cmntBtn").attr("disabled", "true");
    $(".cmntText").keyup(function(){
        if ($(this).val() != initVal) {
            $(".cmntBtn").removeAttr("disabled");
        } else {
            $(".cmntBtn").attr("disabled", "true");
        }
    });
});