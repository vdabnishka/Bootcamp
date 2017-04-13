var app = angular.module("app", []);

app.factory("areaService", ["$http", function ($http) {
    var service = {};
    service.get = function () {
        return $http.get("/api/AreaQuery/");
    };

    return service;
}]);

app.controller("areaCtrl", function ($scope, areaService) {
    getAreas();

    function getAreas() {
        areaService.get().then(function (response) {
            $scope.areas = response.data;
        });
    }
});

