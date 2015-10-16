/// <reference path="angular.js" />
/// <reference path="jquery-1.10.2.intellisense.js" />
/// <reference path="ngDraggable.js" />


angular.module('GameApp',[]).
        controller('MainCtrl', function ($scope) {
            $scope.GamesList = [];           

            var gameList = $.getJSON("/Home/GameList").success(function (data, status, headers, config) {
                $scope.GamesList = data;
                $scope.$apply();
            });
        });

