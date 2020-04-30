
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

function FormFocused(idForm) {
    debugger;
    var array = $("#" + idForm).serializeArray();
    for (var i = 0; i < array.length; i++) {
        $("[name='" + array[i].name+"']").focus();
        $("[name='" + array[i].name + "']").blur();
    }
}


function Toast(message) {
    M.toast({ html: message, displayLength: '3000' });
}