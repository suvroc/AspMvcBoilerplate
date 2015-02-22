angular.module('taskApplication')
    .factory('taskService', function ($http) {
    return {
        getTask: function (taskId) {
            var promise = $http.get('/Task/GetTask',
                { params: { taskId: taskId } })
                .then(function (response) {
                    //console.log(response);
                    return response.data;
                });
            return promise;
        },
        getTasks: function () {
            var promise = $http.get('/Task/GetAll')
                .then(function (response) {
                    //console.log(response);
                    return response.data;
                });
            return promise;
        },
        addTask: function (task) {
            var promise = $http.get('/Task/AddTask',
                {
                    params: task
                }).then(function (response) {
                    //console.log(response);
                    return response.data;
                });
            return promise;
        },
        markTask: function (taskId) {
            var promise = $http.post('/Task/MarkTaskAsFinished',
                {
                    taskId: taskId
                }).then(function (response) {
                    //console.log(response);
                    return response.data;
                });
            return promise;
        }
    };
});