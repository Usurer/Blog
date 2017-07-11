/// <binding ProjectOpened='watch' />
'use strict';

var gulp = require('gulp');
var sass = require('gulp-sass');
var flatten = require('gulp-flatten');
var cleanCSS = require('gulp-clean-css');
var rename = require('gulp-rename');

gulp.task('default', ['sass', 'minify', 'watch']);

gulp.task('sass', function () {
    return gulp.src('Styles/**/*.scss')
        .pipe(sass())
        .pipe(flatten())
        .pipe(gulp.dest('Styles/css'));
});

gulp.task('minify', function () {
    return gulp.src(['Styles/css/*.css', '!Styles/css/*.min.css'])
        .pipe(sass())
        .pipe(flatten())
        .pipe(cleanCSS())
        .pipe(rename({
            suffix: '.min'
        }))
        .pipe(gulp.dest('Styles/css'));
});

gulp.task('watch', function () {
    gulp.watch('Styles/**/*.scss', ['sass', 'minify']);
});