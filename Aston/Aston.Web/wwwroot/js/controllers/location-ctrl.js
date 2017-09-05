/**
 * Location Controller
 */

app.controller('LocationCtrl', function ($scope, locationResource) {
    var locationResources = new locationResource();
    $scope.test = "hahaha";
    $scope.locationlist = [];
    $scope.location = {};
    $scope.actionstatus = "";
    $scope.categorylist = [
        { id: 1, value: "Furniture" },
        { id: 2, value: "Electronic" },
        { id: 3, value: "Storage" },
        { id: 4, value: "Computer" },
    ];

    function LocationModel() {
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

    locationResources.$GetLocation(function (data) {
        $scope.locationlist = data.obj;
    });

    $scope.add = function () {
        $scope.location = LocationModel();
        $scope.actionstatus = "Create";
        $("#modal-action").modal('show');
    }

    $scope.create = function () {
        var locationResources = new locationResource();
        locationResources.Name = $scope.location.Name;
        locationResources.Description = $scope.location.Description;
        locationResources.IsMovable = $scope.location.IsMovable;
        locationResources.Owner = $scope.location.Owner;
        locationResources.PurchaseDate = $scope.location.PurchaseDate;
        locationResources.PurchasePrice = parseFloat($scope.location.PurchasePrice);
        locationResources.ManufactureDate = $scope.location.ManufactureDate;
        locationResources.CategoryCD = $scope.location.CategoryCD;
        console.log(locationResources);
        locationResources.$CreateLocation(function (data) {
            $scope.locationlist = data.obj;
        });
    }

    $scope.edit = function(obj) {
        $scope.location = obj;
        $scope.actionstatus = "Update";
        $("#modal-action").modal('show');
    }

    $scope.update = function() {
        var locationResources = new locationResource();
        locationResources.Name = $scope.location.Name;
        locationResources.Description = $scope.location.Description;
        locationResources.IsMovable = $scope.location.IsMovable;
        locationResources.Owner = $scope.location.Owner;
        locationResources.PurchaseDate = $scope.location.PurchaseDate;
        locationResources.PurchasePrice = parseFloat($scope.location.PurchasePrice);
        locationResources.ManufactureDate = $scope.location.ManufactureDate;
        locationResources.CategoryCD = $scope.location.CategoryCD;
        locationResources.$UpdateLocation(function (data) {
            $scope.locationlist = data.obj;
        });
    }

    $scope.isSelectedItem = function (itemA, itemB) {
        return itemA == itemB ? true : false;
    }

    $scope.deletemodal = function () {
        $scope.location = LocationModel();
        $scope.actionstatus = "Delete";
        $("#modal-action").modal('show');
    }
    $scope.delete = function() {
        var locationResources = new locationResource();
        locationResources.Name = $scope.location.Name;
        locationResources.Description = $scope.location.Description;
        locationResources.IsMovable = $scope.location.IsMovable;
        locationResources.Owner = $scope.location.Owner;
        locationResources.PurchaseDate = $scope.location.PurchaseDate;
        locationResources.PurchasePrice = parseFloat($scope.location.PurchasePrice);
        locationResources.ManufactureDate = $scope.location.ManufactureDate;
        locationResources.CategoryCD = $scope.location.CategoryCD;
        locationResources.$DeleteLocation(function (data) {
            $scope.locationlist = data.obj;
        });
    }

});