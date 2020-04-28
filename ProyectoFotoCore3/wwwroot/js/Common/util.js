
function LoadPartial(div, url, method, data) {

    return $.ajax({
        method: method,
        url: url,
        dataType: 'html',
        data: data,
        success: function (response) {
            $("#" + div).html(response);
            console.log(response);
        },
        error: function () {
            return null;
        }

    });
}

function SendForm(url, method, data) {

    return $.ajax({
        method: method,
        url: url,
        data: data,
        success: function (response) {
            return response;
        },
        error: function () {
            return response;
        }
    });
}
