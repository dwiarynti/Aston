using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aston.Business;
using System.Net.Http;
using Aston.Entities;
using System.Net;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Aston.WebApi.Controllers
{
 
    [Route("api/AssetLocation")]
    public class AssetLocationController : Controller
    {
        public AssetLocationComponent service = new AssetLocationComponent();

        [HttpPost]
        [Route("MoveAsset")]
        public HttpResponseMessage MoveAsset(HttpRequestMessage request, [FromBody] AssetViewModel obj)
        {
            var result = service.MoveAsset(obj);
            HttpResponseMessage response = new HttpResponseMessage();
            response = request.CreateResponse(HttpStatusCode.OK, new { success = result });
            return response;
        }
    }
}
