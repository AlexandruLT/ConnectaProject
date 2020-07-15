$(document).ready(function () {
    $('.btn.btn-default.login').click( function (e) {

    var model = JSON.stringify({
        'Username': $('.form-control.username').val(),
        'Password': $('.form-control.password').val()
    });

    $.ajax({

        type: "POST",

        url: 'User/Login/',

        data: model,

        contentType: "application/json; charset=utf-8",

        complete: function (response) {
            alert('Welcome')
        },

        error: function (XMLHttpRequest, textStatus, errorThrown) {

            alert('Error')

        }

    });

    });
});

