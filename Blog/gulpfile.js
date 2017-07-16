/// <binding ProjectOpened='watch' />
'use strict';

var gulp = require('gulp');
var sass = require('gulp-sass');
var flatten = require('gulp-flatten');
var cleanCSS = require('gulp-clean-css');
var rename = require('gulp-rename');
var typescript = require('gulp-typescript');

gulp.task('default', ['sass', 'minify:css', 'typescript:compile', 'watch']);

gulp.task('sass', function () {
    return gulp.src('Styles/**/*.scss')
        .pipe(sass())
        .pipe(flatten())
        .pipe(gulp.dest('Styles/css'));
});

gulp.task('minify:css', function () {
    return gulp.src(['Styles/css/*.css', '!Styles/css/*.min.css'])
        .pipe(sass())
        .pipe(flatten())
        .pipe(cleanCSS())
        .pipe(rename({
            suffix: '.min'
        }))
        .pipe(gulp.dest('Styles/css'));
});

gulp.task('typescript:compile', function () {
    var result = gulp.src('Scripts/*.ts')
        .pipe(typescript({
            noImplicitAny: true
        }));

    return result.js.pipe(gulp.dest('Scripts/js'));
});

gulp.task('watch', function () {
    gulp.watch('Styles/**/*.scss', ['sass', 'minify:css']);
    gulp.watch('Scripts/*.ts', ['typescript:compile']);
});

