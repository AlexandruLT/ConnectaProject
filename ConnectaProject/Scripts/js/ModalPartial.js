 $(document).ready(function () {

     $('.btn.btn-primary.waves-effect.waves-light').click(function () {

         var url = $('.HtmlForm').attr('id');

            $('#myModal').modal({

                backdrop: 'static',

                keyboard: false

            })

            .on('click', '#confirmok1', function (e) {

                $.ajax({

                    type: "POST",

                    url: '@Url.Action("Add"' + url + ')',

                    data: '{' + url + 'Key: ' + JSON.stringify(id) + '}',

                    dataType: "json",

                    contentType: "application/json; charset=utf-8",

                    success: function (response) {

                        window.location.reload();

                        

                        $('#myModal').modal('hide');

                    },

                    error: function (XMLHttpRequest, textStatus, errorThrown) {

                        alert('Error')

                    }

                });

            });

        });

        

        });
