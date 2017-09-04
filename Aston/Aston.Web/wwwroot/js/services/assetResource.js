(function () {
    "use strict";
    angular
        .module("common.services")
        .factory("assetResource",
                ["$resource",
                 assetResource]);
    function assetResource($resource) {
        return $resource("/api/Asset/:action/:BranchID/:assetID/:UpdatedBy",
        { id: '@id' },
        {
            GetAsset: { method: 'GET', params: { action: 'GetAsset' } },

        });
    }
}());