(function () {
    $(document).ready(function () {
        var form = $('.js-editor-form');
        form.on('submit', function (e) {
            var content = tinymce.editors[0].getContent();

            $.ajax({
                type: 'POST',
                url: '/Blogpost/Add',
                data: { data: content },
                success: function () {
                    // TODO: This won't put newly added content on a page. So either return it from Action and push into DOM, or reload the page
                    tinymce.editors[0].setContent();                
                }
            });

            e.preventDefault();
            e.stopPropagation();

            return false;
        });
    });
})()