
$(function () {

    var ajaxFormSubmit = function () {
        var $form = $(this);

        var options = {
            url: $form.attr("action"),
            type: $form.attr("method"),
            data: $form.serialize()
        };

        $.ajax(options).done(function (data) {
            var $target = $($form.attr("data-mvc4-target"));
            $target.replaceWith(data);
        });
        
        return false;
    };

    var createAutocomplete = function () {
        var $input = $(this);
    }

    $("form[data-mvc4-ajax='true']").submit(ajaxForSubmit);
    $("input[data-mvc4-autocomplete").each(createAutocomplete);
});