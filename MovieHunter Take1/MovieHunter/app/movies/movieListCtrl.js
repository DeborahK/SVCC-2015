(function () {
    "use strict";

    angular
    .module("movieHunter")
    .controller("MovieListCtrl",
                [MovieListCtrl]);

    function MovieListCtrl() {
        var vm = this;

        vm.movies = [];
        vm.title = "Search by Movie Title";
        vm.showImage = false;

        vm.toggleImage = function () {
            vm.showImage = !vm.showImage;
        };
    }

}());

