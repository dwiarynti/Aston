using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Aston.Web.Process;
using System.Net.Http;
using Aston.Entities;

namespace Aston.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/AssetLocation")]
    public class AssetLocationController : Controller
    {
        private readonly AssetLocationProcess _assetLocationProcess;
        public AssetLocationController(AssetLocationProcess assetLocationProcess)
        {
            _assetLocationProcess = assetLocationProcess;
        }

        [HttpPost]
        [Route("MoveAsset")]
        public HttpResponseMessage MoveAsset(HttpRequestMessage request, [FromBody] AssetViewModel obj)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            obj.CreatedBy = User.Identity.Name;
            response = _assetLocationProcess.MoveAsset(obj);
            return response;
        }
    }
}