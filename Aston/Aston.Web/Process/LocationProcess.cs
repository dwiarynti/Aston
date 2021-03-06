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
    public class LocationProcess : ProcessComponent
    {
        private readonly AppSetting _serviceSettings;
        public LocationProcess(IOptions<AppSetting> serviceSettings) : base(serviceSettings)
        {
            _serviceSettings = serviceSettings.Value;
        }
        public HttpResponseMessage GetLocationByCode(string barcode)
        {
            HttpResponseMessage result = default(HttpResponseMessage);
            string requestUri = "api/location/GetLocationByCode/" + barcode;
            result = REST(requestUri, RESTConstants.GET);
            return result;
        }
        public HttpResponseMessage GetLocationByID(int id)
        {
            HttpResponseMessage result = default(HttpResponseMessage);
            string requestUri = "api/location/GetLocationByID/" + id;
            result = REST(requestUri, RESTConstants.GET);
            return result;
        }
        public HttpResponseMessage GetLocation()
        {
            HttpResponseMessage result = default(HttpResponseMessage);
            string requestUri = "api/location/GetLocation/";
            result = REST(requestUri, RESTConstants.GET);
            return result;
        }

        public HttpResponseMessage CreateLocation(Location obj)
        {
            HttpResponseMessage result = default(HttpResponseMessage);
            string requestUri = "api/location/CreateLocation";
            result = REST(requestUri, RESTConstants.POST, JsonConvert.SerializeObject(obj));
            return result;
        }
        public HttpResponseMessage UpdateLocation(Location obj)
        {
            HttpResponseMessage result = default(HttpResponseMessage);
            string requestUri = "api/location/UpdateLocation";
            result = REST(requestUri, RESTConstants.POST, JsonConvert.SerializeObject(obj));
            return result;
        }
        public HttpResponseMessage DeleteLocation(Location obj)
        {
            HttpResponseMessage result = default(HttpResponseMessage);
            string requestUri = "api/location/DeleteLocation";
            result = REST(requestUri, RESTConstants.POST, JsonConvert.SerializeObject(obj));
            return result;
        }
    }


}
