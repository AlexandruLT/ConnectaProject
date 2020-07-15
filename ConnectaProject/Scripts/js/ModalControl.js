$(document).ready(function () {



    $('.btn.btn-info.waves-effect.waves-light').click(function () {

        var url = $(this).data('url');

        $.get(url, function (data) {

            $('#myModal').html(data);



            $('#myModal').modal('show');

            $('#ModalPopUp').find('#myModalLabel').html($(this).attr("title"));

        });


    });

    $('.btn-danger').click(function () {

        var id = $(this).attr('id');

        var url = $(this).data('url');

        var split = url.split('/');

        url = split[2];

        $('#myModal1').modal({

            backdrop: 'static',

            keyboard: false

        })

            .on('click', '#confirmOk', function (e) {

                $.ajax({

                    type: 'POST',

                    url: url + '/',

                    data: '{Id: ' + JSON.stringify(id) + '}',

                    dataType: "text",

                    contentType: 'application/json; charset=utf-8',

                    success: function (success) {

                        window.location.reload();

                        $('#myModal ').modal('hide');

                    },

                    error: function (XMLHttpRequest, textStatus, errorThrown) {

                        alert('Error')

                    }

                });

            });

    });

});