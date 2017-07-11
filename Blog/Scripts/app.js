if (typeof BlogApp === 'undefined')
    BlogApp = {};

(function () {
    $(document).ready(function () {
        var form = $('.js-editor-form');

        form.on('submit', function (e) {
            var editorContent = tinymce.editors[0].getContent();
            var pseudoInput = $(document.createElement('textarea'));
            pseudoInput.attr('name', 'data');
            pseudoInput.html(editorContent);
            $(e.target).append(pseudoInput);

            return true;
        });
    });
})()