(function () {
    $(document).ready(function () {
        tinymce.init({
            selector: 'textarea',
            height: 500,
            menubar: false,
            plugins: [],
            toolbar: 'undo redo | insert | styleselect | bold italic | alignleft aligncenter alignright alignjustify | bullist numlist outdent indent | link image',
            content_css: [],
            setup: function (editor) {
                editor.on('init', function (e) {
                    editor.on('Change', function (e) {
                        BlogApp.contentEditor.pushPreview();
                    });

                    //$('.js-editor-form').removeClass('hidden');
                    $('.js-editor-form').addClass('animation-show');
                    $('.js-editor-form').removeClass('hidden');
                });
            }
        });        
    });
})()

