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
        public HttpResponseMessage getAsset()
        {
            HttpResponseMessage result = default(HttpResponseMessage);
            string requestUri = "api/Asset/Getasset/";
            result = REST(requestUri, RESTConstants.GET);
            return result;
        }

    }
}
