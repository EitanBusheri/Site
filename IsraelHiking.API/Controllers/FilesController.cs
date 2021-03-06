﻿using IsraelHiking.DataAccessInterfaces;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using IsraelHiking.API.Services;
using IsraelHiking.Common;

namespace IsraelHiking.API.Controllers
{
    public class FilesController : ApiController
    {
        private readonly IElevationDataStorage _elevationDataStorage;
        private readonly IRemoteFileFetcherGateway _remoteFileFetcher;
        private readonly IDataContainerConverterService _dataContainerConverterService;

        public FilesController(IElevationDataStorage elevationDataStorage,
            IRemoteFileFetcherGateway remoteFileFetcher, 
            IDataContainerConverterService dataContainerConverterService)
        {
            _elevationDataStorage = elevationDataStorage;
            _remoteFileFetcher = remoteFileFetcher;
            _dataContainerConverterService = dataContainerConverterService;
        }
        /// <summary>
        /// Gets a file from an external Url and converts it to data container
        /// </summary>
        /// <param name="url">The url to fetch the file from</param>
        /// <returns>A data container after convertion</returns>
        // GET api/files?url=http://jeeptrip.co.il/routes/pd6bccre.twl
        public async Task<DataContainer> GetRemoteFile(string url)
        {
            var response = await _remoteFileFetcher.GetFileContent(url);
            var dataContainer = await _dataContainerConverterService.ToDataContainer(response.Content, response.FileName);
            foreach (var latLngZ in dataContainer.routes.SelectMany(routeData => routeData.segments.SelectMany(routeSegmentData => routeSegmentData.latlngzs)))
            {
                latLngZ.z = await _elevationDataStorage.GetElevation(latLngZ.lat, latLngZ.lng);
            }
            return dataContainer;
        }

        /// <summary>
        /// This function is used to save file from data conatiner (client side presention) to any given format.
        /// </summary>
        /// <param name="format">The format to convert to</param>
        /// <param name="dataContainer">The container to convert</param>
        /// <returns>a byte representation of file in the converted format</returns>
        [HttpPost]
        // POST api/files?format=gpx
        public Task<byte[]> PostSaveFile(string format, [FromBody]DataContainer dataContainer)
        {
            return _dataContainerConverterService.ToAnyFormat(dataContainer, format);
        }

        /// <summary>
        /// The uploaded file is converted to data container json 
        /// </summary>
        /// <returns>A data container after conversion of the file uploaded</returns>
        [HttpPost]
        [Route("api/Files/open")]
        [ResponseType(typeof(DataContainer))]
        public async Task<IHttpActionResult> PostOpenFile()
        {
            var streamProvider = new MultipartMemoryStreamProvider();
            var multipartFileStreamProvider = await Request.Content.ReadAsMultipartAsync(streamProvider);

            if (multipartFileStreamProvider.Contents.Count == 0)
            {
                return BadRequest();
            }
            var fileName = streamProvider.Contents.First().Headers.ContentDisposition.FileName.Trim('"');
            var content = await streamProvider.Contents.First().ReadAsByteArrayAsync();
            var dataContainer = await _dataContainerConverterService.ToDataContainer(content, fileName);
            return Ok(dataContainer);
        }
    }
}
