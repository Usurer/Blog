if (typeof BlogApp === 'undefined')
    BlogApp = {};

(function () {
    $(document).ready(function () {

        function getEditorContent() {
            // TODO: not a safe call at all.
            return tinymce.editors[0].getContent();
        }

        function getPreviewContainer() {
            return $('.js-editor-preview-container').first();
        }

        function pushPreview() {
            var data = getEditorContent();
            var container = getPreviewContainer()
            container.html(data);
        }

        BlogApp.contentEditor = {
            pushPreview: pushPreview
        }
    });
})()