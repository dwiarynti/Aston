using Aston.Entities;
using Aston.Web.Base;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Aston.Web.Process
{
    public class AssetProcess : ProcessComponent
    {
        private readonly AppSetting _serviceSettings;
        public AssetProcess(IOptions<AppSetting> serviceSettings) : base(serviceSettings)
        {
            _serviceSettings = serviceSettings.Value;
        }
        public HttpResponseMessage GetAssetInfo(string barcode)
        {
            HttpResponseMessage result = default(HttpResponseMessage);
            string requestUri = "api/Asset/GetAssetInfo/" + barcode;
            result = REST(requestUri, RESTConstants.GET);
            return result;
        }

        public HttpResponseMessage GetAsset()
        {
            HttpResponseMessage result = default(HttpResponseMessage);
            string requestUri = "api/Asset/GetAsset/";
            result = REST(requestUri, RESTConstants.GET);
            return result;
        }


        public HttpResponseMessage CreateAsset(Asset obj)
        {
            HttpResponseMessage result = default(HttpResponseMessage);
            string requestUri = "api/Asset/CreateAsset";
            result = REST(requestUri, RESTConstants.POST, JsonConvert.SerializeObject(obj));
            return result;
        }
        public HttpResponseMessage UpdateAsset(Asset obj)
        {
            HttpResponseMessage result = default(HttpResponseMessage);
            string requestUri = "api/Asset/UpdateAsset";
            result = REST(requestUri, RESTConstants.POST, JsonConvert.SerializeObject(obj));
            return result;
        }
        public HttpResponseMessage DeleteAsset(Asset obj)
        {
            HttpResponseMessage result = default(HttpResponseMessage);
            string requestUri = "api/Asset/DeleteAsset";
            result = REST(requestUri, RESTConstants.POST, JsonConvert.SerializeObject(obj));
            return result;
        }

    }
}
