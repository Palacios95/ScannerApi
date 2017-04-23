using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;

namespace ScannerApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Scanner")]
    public class ScannerController : Controller
    {

        // POST api/values
        [HttpGet]
        public IActionResult Get(string filename)
        {

            string path = $"Scans/{filename}.obj";

            FileContentResult result = new FileContentResult(System.IO.File.ReadAllBytes(path), "application/octet-stream")
            {
                FileDownloadName = path
            };
            return result;


        }

    }
}