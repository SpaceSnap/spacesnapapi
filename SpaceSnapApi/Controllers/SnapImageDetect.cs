using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Google.Cloud.Vision.V1;
using Google.Apis.Auth.OAuth2;

namespace SpaceSnapApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SnapImageDetect : ControllerBase
    {

        private readonly ILogger<SnapImageDetect> _logger;

        public SnapImageDetect(ILogger<SnapImageDetect> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var client = ImageAnnotatorClient.Create();
			//ImageAnnotatorClient.Create()

            var image = Image.FromUri("gs://cloud-vision-codelab/otter_crossing.jpg");
            //var response = client.DetectText(image);
			var response = await client.DetectLabelsAsync(image);
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                {
                    Console.WriteLine(annotation.Description);
                }
            }

			return Ok("Success");
		}
	}
}
