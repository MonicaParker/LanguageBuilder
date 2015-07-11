/// <reference path="../scripts/typings/angularjs/angular.d.ts" />
/// <reference path="../scripts/typings/angularjs/angular-resource.d.ts" />
/// <reference path="../scripts/typings/jquery/jquery.d.ts" />


(function () {
    angular.module("LangHelper").factory('RunesService', function ($resource) {
        var self = this;
        var Rune = $resource('/api/runes/:id');
        var runes = Rune.query();
        var count = runes.length;
        
        return {
            Rune: Rune,
            runes: runes,
            count: count,
        };
    });

})();