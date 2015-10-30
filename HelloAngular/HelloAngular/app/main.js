
var app = angular.module("app", []);

app.controller('Main', function ($scope,PersonService) {

    $scope.loading = true;
    $scope.addMode = false;

    PersonService.getPerson().success(function (data) {
              $scope.persons = data;
          });

})