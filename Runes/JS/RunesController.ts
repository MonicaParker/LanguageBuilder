/// <reference path="../scripts/typings/angularjs/angular.d.ts" />
/// <reference path="../scripts/typings/jquery/jquery.d.ts" />
/// <reference path="runesservice.ts" />

//Brian, you are crazy and your language is ridiculous and I will have my revenge.

(function () {
    angular.module("LangHelper").controller('RunesController', function ($location, RunesService, $resource) {
        var self = this;

        //Rune item
        //Working!
        var Rune = RunesService.Rune;

        //All runes
        //Working!
        self.runes = RunesService.runes;

        self.count = function () {
            return RunesService.runes.length;
        }

        //Create rune 
        //Working!
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

        //Validation needs:
        //Validation for transliteration; validation for img url, 
       
        //Edit rune
        $(".display").dblclick(function (original) {
            alert(original);

            //Persist changes to server
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
        //Working!
        self.remove = function (original) {
            original.$remove({ id: original.Id }, function () {
                self.runes = self.runes.filter(function (rune) {
                    return rune.Id != original.Id;
                });
            });
        };

    });

    //Supports edit in place feature
    angular.module("LangHelper").run(function (editableOptions) {
        editableOptions.theme = 'bs3';
    });

})();