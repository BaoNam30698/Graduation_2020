(function () {
    var controllerId = 'app.common.layout';
    angular.module('app').controller(controllerId, [
        '$scope', '$timeout', function ($scope, $timeout) {
            var vm = this;
            //Layout logic...
            console.log('lolol');

            vm.activateLeftSideBar = function () {
                $timeout(function () {
                    $.AdminBSB.leftSideBar.activate();
                }, 2000);
            };

            vm.activateRightSideBar = function () {
                $timeout(function () {
                    $.AdminBSB.rightSideBar.activate();
                }, 2000);
            };


            vm.activateTopBar = function () {
                $.AdminBSB.search.activate();
                $.AdminBSB.navbar.activate();
            };

        }]);
})();