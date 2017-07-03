(function () {
    $(document).ready(function () {
        var form = $('.js-editor-form');
        form.on('submit', function (e) {
            var content = tinymce.editors[0].getContent();

            $.ajax({
                type: 'POST',
                url: '/Blogpost/Add',
                data: { data: content }
            });

            //$.post("/Blogpost/Add", { content: JSON.stringify(content) }, "json);

            e.preventDefault();
            e.stopPropagation();

            return false;
        });
    });
})()