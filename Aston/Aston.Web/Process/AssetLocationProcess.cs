﻿using Aston.Entities;
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
    public class AssetLocationProcess : ProcessComponent
    {
        private readonly AppSetting _serviceSettings;
        public AssetLocationProcess(IOptions<AppSetting> serviceSettings) : base(serviceSettings)
        {
            _serviceSettings = serviceSettings.Value;
        }
        public HttpResponseMessage MoveAsset(AssetViewModel obj)
        {
            HttpResponseMessage result = default(HttpResponseMessage);
            string requestUri = "api/Asset/MoveAsset";
            result = REST(requestUri, RESTConstants.POST, JsonConvert.SerializeObject(obj));
            return result;
        }
    }
}
