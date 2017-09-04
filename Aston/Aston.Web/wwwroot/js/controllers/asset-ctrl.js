/**
 * Asset Controller
 */

app.controller('AssetCtrl', function ($scope, assetResource) {
    var assetResources = new assetResource();
    $scope.test = "hahaha";
    $scope.assetlist = [];

    assetResources.$GetAsset(function (data) {
        console.log(data);
        $scope.assetlist = data.obj;
    });

});