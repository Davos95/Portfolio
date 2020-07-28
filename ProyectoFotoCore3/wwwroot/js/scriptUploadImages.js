$(document).ready(function () {
    var arrayImages;
    $("#drop-area").on('dragenter', function (e) {
        e.preventDefault();
        $(this).css('border-color', '#81c784');
    });

    $("#drop-area").on('dragleave', function (e) {
        e.preventDefault();
        $(this).css('border-color', 'grey');
    });

    $("#drop-area").on('dragover', function (e) {
        e.preventDefault();
    });

    $("#drop-area").on('drop', function (e) {
        $(this).css('background', '#D8F9D3');
        e.preventDefault();
        arrayImages = e.originalEvent.dataTransfer.files;
        debugger;
        $("#files")[0].files = arrayImages;
        
        console.log($("#files"));

        //for (var i = 0; i < arrayImages.length; i++) {

        //    var image = arrayImages[i];
        //    var reader = new FileReader();
        //    reader.onload = function (e) {
        //        var pic = e.target;
        //        $("#div").append("<img src='" + pic.result + "' style='width: 150px; height: 150px'>");
        //    }
        //    reader.readAsDataURL(image);
        //}

    });

    $("#files").change(function (e) {
        arrayImages = e.target.files;
    });

    $("#send").click(function () {
        var sesion = $("#IdSesion").val();
        console.log(sesion);
        uploadData(arrayImages, sesion);

    });

});


function uploadData(arrayImages, sesion) {

    var formData = new FormData();
    for (var i = 0; i < arrayImages.length; i++) {
        formData.append("File" + i, arrayImages[i]);
    }

    formData.append("IdSesion", sesion);

    $.ajax({
        type: "POST",
        url: "/Foto/Upload",
        data: formData,
        contentType: false,
        processData: false,
        beforeSend: function () {
            $("#loading").fadeIn(100);
        },
        success: function (data) {
            console.log(data);
            setTimeout(function () {
                $("#loading").fadeOut(100);
            }, 1000);

        },
        error: function () {

            $("#loading").fadeOut(100);
            alert("Ha ocurrido un error!");
        }
    });

}