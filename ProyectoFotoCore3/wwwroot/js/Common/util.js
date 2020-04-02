
function LoadPartial(div, url, method, data) {

    return $.ajax({
        method: method,
        url: url,
        dataType: 'html',
        data: data,
        success: function (response) {
            $("#" + div).html(response);
        },
        error: function () {
            return null;
        }

    });
}

