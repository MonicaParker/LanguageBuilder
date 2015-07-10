/// <reference path="../scripts/typings/angularjs/angular.d.ts" />
/// <reference path="../scripts/typings/angularjs/angular-resource.d.ts" />
/// <reference path="../scripts/typings/jquery/jquery.d.ts" />
(function () {
    angular.module("LangHelper").factory('RunesService', function ($resource) {
        var Rune = $resource('/api/runes/:id');
        var runes = Rune.query();
        return {
            Rune: Rune,
            runes: runes
        };
    });
})();
//# sourceMappingURL=runesservice.js.map