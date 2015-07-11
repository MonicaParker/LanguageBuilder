(function () {
    angular.module("LangHelper", ['ngRoute', 'ngResource', 'xeditable']).config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
        $routeProvider
        .when('/', {
            templateUrl: '/ngViews/Wheel.html',
            conroller: 'MainController',
            controllerAs: 'main'
        })
        .when('/rune', {
            templateUrl: '/ngViews/Runes.html',
            controller: 'RunesController',
            controllerAs: 'main'
        })
        .when('/test-compare', {
            templateUrl: '/ngViews/TestComparison.html',
            controller: 'TestController',
            controllerAs: 'main'
        })
        .when ('/test-word', {
            templateUrl: '/ngViews/TestWord.html',
            controller: 'TestController',
            controllerAs: 'main'
        })
        .when('/test-sentence', {
            templateUrl: '/ngViews/TestSentence.html',
            controller: 'TestController',
            controllerAs: 'main'
        })
        $locationProvider.html5Mode(true);
    }]);
})();