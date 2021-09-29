// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function addCourse(id, username) {
    $.post({
        url: "Add?Courseid=" + id + "&Username=" + username,
        success: function () {
            alert("加選成功")
        }
    }).fail(function () { alert("加選失敗") });
}

function dropCourse(id, username) {
    $.post({
        url: "Drop?Courseid=" + id + "&Username=" + username,
        success: function () {
            alert("退選成功")
        },
    }).fail(function () { alert("退選失敗") })
        .always(function () { location.reload() });
}
