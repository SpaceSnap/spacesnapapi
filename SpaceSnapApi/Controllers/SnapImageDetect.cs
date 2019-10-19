using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Google.Cloud.Vision.V1;
using Google.Apis.Auth.OAuth2;
using SpaceSnapApi.Models;

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
            var labelsModel = new LabelsModel();
            var labelsModelList = new List<LabelsModel>();
            var image = Image.FromUri("gs://cloud-vision-codelab/otter_crossing.jpg");

            //var response = client.DetectText(image);
			var response = await client.DetectLabelsAsync(image);

            foreach (var label in response)
            {
                var label2 = new LabelsModel();
                if (label != null)
                {
                    label2.Description= label.Description;
                    label2.Score = label.Score;
                }

                labelsModelList.Add(label2);
            };
			return Ok(labelsModelList);
		}
	}
}
