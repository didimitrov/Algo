$(document).ready(function (e) {
    $('#paintElement').on('click', function () {
        var classValue = $('#classElement').val();
        var colorValue = $('#color').val();

        if (classValue) {
            $('.' + classValue).css('background', colorValue)
        }
        
    });
    e.preventDefault();
});