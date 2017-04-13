var app = angular.module("app", []);
app.factory("areaSvc", ["$http", function ($http) {
        var service = {};
        service.get = function () {
            return $http.get("/api/AreaQuery/");
        };
        return service;
    }]);
app.controller("areaCtrl", function ($scope, areaSvc) {
    getAreas();
    function getAreas() {
		areaSvc.get().then(function (response) {
            $scope.areas = response.data;
        });
    }
});
//# sourceMappingURL=app.js.map 
//# sourceMappingURL=app.js.map