$(document).ready(
    function () {
        $("#btn_get_reviews").click(
            function () {
                $.getJSON("/reviews/", function (data) { alert(data); });
            }
        );

    }
);