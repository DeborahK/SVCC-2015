(function () {
    "use strict";

    angular
        .module("movieHunter")
        .controller("MovieDetailCtrl",
                    ["movieResource",
                        "$routeParams",
                     MovieDetailCtrl]);

    function MovieDetailCtrl(movieResource, $routeParams) {
        var vm = this;

        vm.movieId = $routeParams.movieId;
        vm.movie = "";

        movieResource.get({ id: vm.movieId },
            function (data) {
                vm.movie = data;
            });
    }
}());