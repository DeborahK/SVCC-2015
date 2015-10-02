(function () {
    "use strict";

    angular
    .module("movieHunter")
    .controller("MovieListCtrl",
                ["movieResource",
                    MovieListCtrl]);

    function MovieListCtrl(movieResource) {
        var vm = this;

        vm.movies = [];
        vm.title = "Search by Movie Title";
        vm.showImage = false;

        vm.toggleImage = function () {
            vm.showImage = !vm.showImage;
        };

        movieResource.query(
            function (data) {
                vm.movies = data;
            });
    }

}());

