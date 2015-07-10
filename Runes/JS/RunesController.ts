/// <reference path="../scripts/typings/angularjs/angular.d.ts" />
/// <reference path="../scripts/typings/jquery/jquery.d.ts" />
/// <reference path="runesservice.ts" />

(function () {
    angular.module("LangHelper").controller('RunesController', function ($location, RunesService) {
        var self = this;

        //Rune item
        var Rune = RunesService.Rune;

        //All runes
        self.runes = RunesService.runes;

        //function openCreate() {
        //    var modalInstance = $modal.open({
        //        templateUrl: '/ngViews/Create.Html',
        //        controller: 'PageController'
        //    });
        //};

        //Create rune
        self.add = function () {
            var name = self.newRune.Name;
            var firstLetter = name.charAt(0);

            var newRune = new Rune({
                Name: self.newRune.Name,
                Character: self.newRune.Character,
                Short: self.newRune.Short,
                Meaning: self.newRune.Meaning,
                Extras: self.newRune.Extras,

                Cardinal: self.newRune.Cardinal,
                Locked: self.newRune.Locked,
            });
            newRune.$save(function (result) {
                self.runes.push(result);
            });
        };
        //Sorting takes place client side, during filtering.

        //Edit rune
        //Want to be able to double click on display field to edit.
        $(".display").dblclick(function (original) {
            alert(original);

            //I'd only be double clicking one field at a time, not submitting them all. Can I do this?
            var updatedRune = new Rune({
                Id: self.newRune.Id,
                Character: self.newRune.Character,
                Short: self.newRune.Short,
                Meaning: self.newRune.Meaning,
                Extras: self.newRune.Extras,

                Cardinal: self.newRune.Cardinal,
                Locked: self.newRune.Locked
            });
        });

        
        //Delete rune
        self.remove = function (original) {
            original.$remove({ id: original.Id }, function () {
                self.runes = self.runes.filter(function (rune) {
                    return rune.Id != original.Id;
                });
            });
        };

    });

})();