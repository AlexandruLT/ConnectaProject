$(function () {
    $("#modal").click(function () {
            $("<div />").appendTo("body").dialog({
                close: function (event, ui) {
                    dialog.remove();
                },
                modal: true
            }).load(this.href, {});

            return false;            
        });
    });