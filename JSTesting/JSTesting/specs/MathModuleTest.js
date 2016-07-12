/// <reference path="C:\Users\Alexandr_Digilevich\Source\Repos\FinalProject\JSTesting\JSTesting\scripts/angular.js" />
/// <reference path="C:\Users\Alexandr_Digilevich\Source\Repos\FinalProject\JSTesting\JSTesting\scripts/angular-mocks.js" />
/// <reference path="C:\Users\Alexandr_Digilevich\Source\Repos\FinalProject\JSTesting\JSTesting\scripts/jasmine/jasmine.js" />
/// <reference path="C:\Users\Alexandr_Digilevich\Source\Repos\FinalProject\JSTesting\JSTesting\scripts/Controllers/Maths.js" />

describe('MathsModule', function() {
    beforeEach(module('Maths'));

    describe('SumController', function() {
        var scope, controller;

        beforeEach(inject(function ($rootScope, $controller) {
            scope = $rootScope.$new();

            controller = $controller('SumController', {
                $scope: scope
            });
        }));

        it('Should return the sum of two values', function() {
            var result = scope.sum(10, 20);

            expect(result).toEqual(30);
        });
    });
});

describe('')