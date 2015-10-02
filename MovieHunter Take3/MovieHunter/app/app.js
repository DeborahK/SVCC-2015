(function () {
    "use strict";

    var app = angular.module("movieHunter", ["ngRoute", "common.services"]);

    app.config(["$routeProvider",
        function ($routeProvider) {
            $routeProvider
                .when("/", {
                    templateUrl : "app/welcomeView.html"
                })
                .when("/searchByTitle", {
                    templateUrl : "app/movies/movieListView.html",
                    controller : "MovieListCtrl as vm"
                })
                .when("/showDetail/:movieId", {
                    templateUrl : "app/movies/movieDetailView.html",
                    controller : "MovieDetailCtrl as vm"
                })
                .otherwise("/");
        }]);
}());