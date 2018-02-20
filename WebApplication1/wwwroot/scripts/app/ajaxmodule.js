var ajaxModule = function () {
    var my = {};

    my.init = function () {
        my.wireEvents();
    };

    my.wireEvents = function () {
        $(document).on('click', '[data-command="getData"]', my.getData);
    };

    my.getData = function() {
        var url = $(this).data('url');
        $.get(url,
            function(data) {
                //data ist im JSON Format
                $('#eins').html(data.eins); //ASP .NET Core benennt die Properties im JSON immer mit führendem kleinen Buchstaben, daher "eins" und nicht "Eins" wie im Model
                $('#zwei').html(data.zwei);
                alert(JSON.stringify(data));
            });
    }


    my.init();

    return my;
}();