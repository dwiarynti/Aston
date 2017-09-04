﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aston.Business;
using System.Net.Http;
using Aston.Entities;
using Aston.Entities.DataContext;
using System.Net;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Aston.WebApi.Controllers
{
   
  
    [Route("api/Asset")]
    public class AssetController : Controller
    {
        public AssetComponent service = new AssetComponent();


        [HttpGet]
        [Route("GetAssetInfo/{barcode}")]
        public HttpResponseMessage GetAssetInfo(HttpRequestMessage request ,string barcode)
        {

            var result = service.GetAssetInfo(barcode);
            HttpResponseMessage response = new HttpResponseMessage();
            response = request.CreateResponse(HttpStatusCode.OK, new { success = true, obj = result });
            return response;
        }

        [HttpGet]
        [Route("GetAsset")]
        public HttpResponseMessage GetAsset(HttpRequestMessage request)
        {

            var result = service.GetAsset();
            HttpResponseMessage response = new HttpResponseMessage();
            response = request.CreateResponse(HttpStatusCode.OK, new { success = true, obj = result });
            return response;
        }



        [HttpPost]
        [Route("CreateAsset")]
        public HttpResponseMessage CreateAsset(HttpRequestMessage request, [FromBody] Asset obj)
        {
            var result = service.CreateAsset(obj);
            HttpResponseMessage response = new HttpResponseMessage();
            response = request.CreateResponse(HttpStatusCode.OK, new { success = result });
            return response;
        }

        [HttpPost]
        [Route("UpdateAsset")]
        public HttpResponseMessage UpdateAsset(HttpRequestMessage request, [FromBody] Asset obj)
        {
            var result = service.UpdateAsset(obj);
            HttpResponseMessage response = new HttpResponseMessage();
            response = request.CreateResponse(HttpStatusCode.OK, new { success = result });
            return response;
        }

        [HttpPost]
        [Route("DeleteAsset")]
        public HttpResponseMessage DeleteAsset(HttpRequestMessage request, [FromBody] Asset obj)
        {
            var result = service.DeleteAsset(obj);
            HttpResponseMessage response = new HttpResponseMessage();
            response = request.CreateResponse(HttpStatusCode.OK, new { success = result });
            return response;
        }



    }
}
