angular.module('taskApplication')
    .controller('TaskController', function ($scope, taskService) {
        "use strict";
        taskService.getTasks().then(function (data) {
            $scope.tasks = data;
        });

        //$scope.selectedRoom = {};

        $scope.openDetails = function (id) {
            var room = taskService.getTask(id)
            .then(function (data) {
                $scope.selectedRoom = data;
            });
            
        };

        $scope.markTask = function (id) {
            taskService.markTask(id)
            .then(function () {
                alert("Zaznaczono");
            });
        }
    })