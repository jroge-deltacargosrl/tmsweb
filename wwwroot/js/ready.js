$(document).ready(function () {
    $(".vertical-nav").on("click", function () {
        $(this).toggleClass("active-nav");
        var url = $(this).children("li").attr("id");
        $(location).attr('href', url);
    });


    $('.clientStates').change(function () {
        var els = this.id.split("-");
        var nuevoHref = "/Refresh/" + els[1] + "/";
        if ($("#client-" + els[1]).is(":checked")) {
            nuevoHref += "1/";
        } else {
            nuevoHref += "0/";
        }
        if ($("#employee-" + els[1]).is(":checked")) {
            nuevoHref += "1/";
        } else {
            nuevoHref += "0/";
        }
        if ($("#supplier-" + els[1]).is(":checked")) {
            nuevoHref += "1";
        } else {
            nuevoHref += "0";
        }
        $("#" + els[1]).attr("href", nuevoHref);
        console.log($("#" + els[1]).attr("href"));
    });

    $('.taskState').change(function () {
        var els = this.id.split("-");
        var nuevoHref = "/TaskChange/" + els[1] + "/";
        if ($("#checkUpload-" + els[1]).is(":checked")) {
            nuevoHref += "1/";
        } else {
            nuevoHref += "0/";
        }
        if ($("#checkView-" + els[1]).is(":checked")) {
            nuevoHref += "1";
        } else {
            nuevoHref += "0";
        }
        $("#taskState" + els[1]).attr("href", nuevoHref);
        console.log($("#taskState" + els[1]).attr("href"));
    });
});
(function () {
    'use strict';
    window.addEventListener('load', function () {
        // Fetch all the forms we want to apply custom Bootstrap validation styles to
        var forms = document.getElementsByClassName('needs-validation');
        // Loop over them and prevent submission
        var validation = Array.prototype.filter.call(forms, function (form) {
            form.addEventListener('submit', function (event) {
                if (form.checkValidity() === false) {
                    event.preventDefault();
                    event.stopPropagation();
                }
                form.classList.add('was-validated');
            }, false);
        });
    }, false);
})();