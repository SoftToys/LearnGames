/// <reference path="angular.js" />
/// <reference path="jquery-1.10.2.intellisense.js" />
/// <reference path="ngDraggable.js" />


angular.module('FindingOddGameApplication', []).
        controller('MainCtrl', function ($scope) {
            $scope.allObjects = [];
            $scope.errors = 0;
            $scope.finished = false;

            var gameobjs = $.getJSON("/Home/FindingOddGame/" + $('#gameTypeId').val()).success(function (data, status, headers, config) {
                $scope.allObjects = data.Objects;
                $scope.Name = data.Name;
                $scope.$apply();
            });



            $scope.onObjectClick = function (obj) {
                if (obj.Correct == true) {
                    $scope.finished = true;
                    $('#dummy-modal-btn').click();
                }
                else {
                    $scope.errors++;
                    obj.Error = true;
                }

            }
        });