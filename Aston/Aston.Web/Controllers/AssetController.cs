using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Aston.Web.Process;

namespace Aston.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Asset")]
    public class AssetController : Controller
    {
        private readonly AssetProcess _assetProcess;

        public AssetController(AssetProcess assetProcess)
        {
            _assetProcess = assetProcess;
        }

        [Route("GetAsset")]
        [HttpGet]
        public HttpResponseMessage GetAsset(HttpRequestMessage request)
        {

            HttpResponseMessage response = new HttpResponseMessage();
            response = _assetProcess.getAsset();
            return response;

        }

    }
}