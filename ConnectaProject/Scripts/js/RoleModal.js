$(document).ready(function () {
    $('.btn.btn-info.waves-effect.waves-light').click(function () {

        $('#example-text-input').val('');

        $('#myModal').modal({

            backdrop: 'static',

            keyboard: false



        })
            .on('click', '.btn.btn-primary.waves-effect.waves-light.save', function (e) {

                var model = JSON.stringify({
                    'Description': $('#example-text-input').val(),
                    'InsertBy': 'Alex'
                });

                $.ajax({

                    type: "POST",

                    url: 'AddRole/',

                    data: model,

                    contentType: "application/json; charset=utf-8",

                    complete: function (response) {
                        window.location.reload();

                        $('#myModal').modal('hide');
                    },

                    error: function (XMLHttpRequest, textStatus, errorThrown) {

                        alert('Error')

                    }

                });

            });

    });


    $('.btn.btn-primary.waves-effect.waves-light.edit').click(function () {

        var id = $(this).attr('id');
        var selector = '#' + id + '.label';
        var value = $(selector).text().trim();

        $('#example-text-input').val(value);

        $('#myModal').modal({

            backdrop: 'static',

            keyboard: false



        })
            .on('click', '.btn.btn-primary.waves-effect.waves-light.save', function (e) {

                var model = JSON.stringify({
                    'Description': $('#example-text-input').val(),
                    'ModifyBy': 'Alex',
                    'BusinessRolesKey': id
                });

                $.ajax({

                    type: "POST",

                    url: 'EditRole/',

                    data: model,

                    contentType: "application/json; charset=utf-8",


                    complete: function (response) {
                        window.location.reload();

                        $('#myModal').modal('hide');
                    },

                    error: function (XMLHttpRequest, textStatus, errorThrown) {

                        alert('Error')

                    }

                });

            });

    });



    $('.btn-danger').click(function () {

        var id = $(this).attr('id');

        $('#myModal1').modal({

            backdrop: 'static',

            keyboard: false

        })

            .on('click', '#confirmOk', function (e) {

                var model = JSON.stringify({
                    'DeletedBy': 'Alex',
                    'BusinessRolesKey': id
                });

                $.ajax({

                    type: 'POST',

                    url: 'DeleteRole/',

                    data: model,

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

    $(".check-box").change(function () {
           var id = $(this).attr('id');
           var selector = '#' + id + '.label';
           var description = $(selector).text().trim();

            var model = JSON.stringify({
                'ModifyBy': 'Alex',
                'BusinessRolesKey': id,
                'EditUsers': $('input#' + id + '.check-box.EditUsers').is(':checked'),
                'EditSurvey': $('input#' + id + '.check-box.EditSurvey').is(':checked'),
                'MakeSurvey': $('input#' + id + '.check-box.MakeSurvey').is(':checked'),
                'AssignSurvey': $('input#' + id + '.check-box.AssignSurvey').is(':checked'),
                'Description': description
            });

            $.ajax({

                type: 'POST',

                url: 'EditRole/',

                data: model,

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