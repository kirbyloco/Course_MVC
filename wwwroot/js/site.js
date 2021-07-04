// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var xmlhttp;
xmlhttp = new XMLHttpRequest();

xmlhttp.onload = function () {
    location.reload()
};

function addCourse(id, username) {
    xmlhttp.open("POST", "Add?Courseid=" + id + "&Username=" + username, true)
    xmlhttp.send()
}

function dropCourse(id, username) {
    xmlhttp.open("POST", "Drop?Courseid=" + id + "&Username=" + username, true)
    xmlhttp.send()
    // setTimeout(location.reload(), 3000)
}
