/**
 * Asset Controller
 */

app.controller('AssetCtrl', function ($scope, assetResource) {
    var assetResources = new assetResource();
    $scope.test = "hahaha";
    $scope.assetlist = [];
    $scope.asset = {};
    $scope.actionstatus = "";
    $scope.categorylist = [
        { id: 1, value: "Furniture" },
        { id: 2, value: "Electronic" },
        { id: 3, value: "Storage" },
        { id: 4, value: "Computer" },
    ];

    function AssetModel() {
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

    assetResources.$GetAsset(function (data) {
        $scope.assetlist = data.obj;
    });

    $scope.add = function () {
        $scope.asset = AssetModel();
        $scope.actionstatus = "Create";
        $("#modal-action").modal('show');
    }

    $scope.create = function () {
        var assetResources = new assetResource();
        assetResources.Name = $scope.asset.Name;
        assetResources.Description = $scope.asset.Description;
        assetResources.IsMovable = $scope.asset.IsMovable;
        assetResources.Owner = $scope.asset.Owner;
        assetResources.PurchaseDate = $scope.asset.PurchaseDate;
        assetResources.PurchasePrice = parseFloat($scope.asset.PurchasePrice);
        assetResources.ManufactureDate = $scope.asset.ManufactureDate;
        assetResources.CategoryCD = $scope.asset.CategoryCD;
        console.log(assetResources);
        assetResources.$CreateAsset(function (data) {
            $scope.assetlist = data.obj;
        });
    }

    $scope.edit = function(obj) {
        $scope.asset = obj;
        $scope.actionstatus = "Update";
        $("#modal-action").modal('show');
    }

    $scope.update = function() {
        var assetResources = new assetResource();
        assetResources.Name = $scope.asset.Name;
        assetResources.Description = $scope.asset.Description;
        assetResources.IsMovable = $scope.asset.IsMovable;
        assetResources.Owner = $scope.asset.Owner;
        assetResources.PurchaseDate = $scope.asset.PurchaseDate;
        assetResources.PurchasePrice = parseFloat($scope.asset.PurchasePrice);
        assetResources.ManufactureDate = $scope.asset.ManufactureDate;
        assetResources.CategoryCD = $scope.asset.CategoryCD;
        assetResources.$UpdateAsset(function (data) {
            $scope.assetlist = data.obj;
        });
    }

    $scope.isSelectedItem = function (itemA, itemB) {
        return itemA == itemB ? true : false;
    }

    $scope.deletemodal = function () {
        $scope.asset = AssetModel();
        $scope.actionstatus = "Delete";
        $("#modal-action").modal('show');
    }
    $scope.delete = function() {
        var assetResources = new assetResource();
        assetResources.Name = $scope.asset.Name;
        assetResources.Description = $scope.asset.Description;
        assetResources.IsMovable = $scope.asset.IsMovable;
        assetResources.Owner = $scope.asset.Owner;
        assetResources.PurchaseDate = $scope.asset.PurchaseDate;
        assetResources.PurchasePrice = parseFloat($scope.asset.PurchasePrice);
        assetResources.ManufactureDate = $scope.asset.ManufactureDate;
        assetResources.CategoryCD = $scope.asset.CategoryCD;
        assetResources.$DeleteAsset(function (data) {
            $scope.assetlist = data.obj;
        });
    }

});