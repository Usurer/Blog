tinymce.init({
    selector: 'textarea',
    height: 500,
    menubar: false,
    plugins: [],
    toolbar: 'undo redo | insert | styleselect | bold italic | alignleft aligncenter alignright alignjustify | bullist numlist outdent indent | link image',
    content_css: [],
    setup: function (editor) {
        editor.on('init', function (e) {
            console.log('Editor was initialized.');

            editor.on('Change', function (e) {
                BlogApp.contentEditor.pushPreview();
            });
        });
    }
});