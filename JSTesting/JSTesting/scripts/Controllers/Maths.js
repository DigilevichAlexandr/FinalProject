/// <reference path="../angular.js" />

angular.module('Maths', [])
    .controller('SumController', function($scope) {
        $scope.sum = function(first, second) {
            return first + second;
        }
    });