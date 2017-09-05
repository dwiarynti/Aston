/**
 * Asset Controller
 */

app.controller('AssetLocationCtrl', function ($scope, assetLocationResource) {
    var assetLocationResources = new assetLocationResource();
    $scope.test = "hahaha";
    $scope.assetlocationlist = [];
    $scope.assetlocation = {};
    $scope.actionstatus = "";
    $scope.categorylist = [
        { id: 1, value: "Furniture" },
        { id: 2, value: "Electronic" },
        { id: 3, value: "Storage" },
        { id: 4, value: "Computer" },
    ];

    function AssetLocationModel() {
        return {
            ID: null,
            Code: null,
            Description: null,
            No: null,
            Name: null,
            IsMovable: null,
            Owner: null,
            PurchaseDate: null,
            PurchasePrice: null,
            DepreciationDuration: null,
            DisposedDate: null,
            ManufactureDate: null,
            CategoryCD: null,
            StatusCD: null,
            CreatedDate: null,
            CreatedBy: null,
            UpdatedDate: null,
            UpdatedBy: null,
            DeletedDate: null,
            DeletedBy: null
        };
    }

    assetLocationResources.$GetAssetLocation(function (data) {
        console.log(data);
        $scope.assetlocationlist = data.obj;
    });

    $scope.add = function () {
        $scope.assetlocation = AssetLocationModel();
        $scope.actionstatus = "Create";
        $("#modal-action").modal('show');
    }

    $scope.create = function () {
        var assetLocationResources = new assetLocationResource();
        assetLocationResources.Name = $scope.assetlocation.Name;
        assetLocationResources.Description = $scope.assetlocation.Description;
        assetLocationResources.IsMovable = $scope.assetlocation.IsMovable;
        assetLocationResources.Owner = $scope.assetlocation.Owner;
        assetLocationResources.PurchaseDate = $scope.assetlocation.PurchaseDate;
        assetLocationResources.PurchasePrice = parseFloat($scope.assetlocation.PurchasePrice);
        assetLocationResources.ManufactureDate = $scope.assetlocation.ManufactureDate;
        assetLocationResources.CategoryCD = $scope.assetlocation.CategoryCD;
        console.log(assetLocationResources);
        assetLocationResources.$CreateAsset(function (data) {
            $scope.assetlocationlist = data.obj;
        });
    }

    $scope.edit = function(obj) {
        $scope.assetlocation = obj;
        $scope.actionstatus = "Update";
        $("#modal-action").modal('show');
    }

    $scope.update = function() {
        var assetLocationResources = new assetLocationResource();
        assetLocationResources.Name = $scope.assetlocation.Name;
        assetLocationResources.Description = $scope.assetlocation.Description;
        assetLocationResources.IsMovable = $scope.assetlocation.IsMovable;
        assetLocationResources.Owner = $scope.assetlocation.Owner;
        assetLocationResources.PurchaseDate = $scope.assetlocation.PurchaseDate;
        assetLocationResources.PurchasePrice = parseFloat($scope.assetlocation.PurchasePrice);
        assetLocationResources.ManufactureDate = $scope.assetlocation.ManufactureDate;
        assetLocationResources.CategoryCD = $scope.assetlocation.CategoryCD;
        assetLocationResources.$UpdateAsset(function (data) {
            $scope.assetlocationlist = data.obj;
        });
    }

    $scope.isSelectedItem = function (itemA, itemB) {
        return itemA == itemB ? true : false;
    }

    $scope.deletemodal = function () {
        $scope.assetlocation = AssetLocationModel();
        $scope.actionstatus = "Delete";
        $("#modal-action").modal('show');
    }
    $scope.delete = function() {
        var assetLocationResources = new assetLocationResource();
        assetLocationResources.Name = $scope.assetlocation.Name;
        assetLocationResources.Description = $scope.assetlocation.Description;
        assetLocationResources.IsMovable = $scope.assetlocation.IsMovable;
        assetLocationResources.Owner = $scope.assetlocation.Owner;
        assetLocationResources.PurchaseDate = $scope.assetlocation.PurchaseDate;
        assetLocationResources.PurchasePrice = parseFloat($scope.assetlocation.PurchasePrice);
        assetLocationResources.ManufactureDate = $scope.assetlocation.ManufactureDate;
        assetLocationResources.CategoryCD = $scope.assetlocation.CategoryCD;
        assetLocationResources.$DeleteAssetLocation(function (data) {
            $scope.assetlocationlist = data.obj;
        });
    }

});