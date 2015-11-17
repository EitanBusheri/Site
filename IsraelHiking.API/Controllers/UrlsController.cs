﻿using IsraelHiking.Common;
using IsraelHiking.DataAccessInterfaces;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace IsraelHiking.API.Controllers
{
    public class UrlsController : ApiController
    {
        private IIsraelHikingRepository _repository;

        public UrlsController(IIsraelHikingRepository repository)
        {
            _repository = repository;
        }

        // GET api/Urls/abc
        public IHttpActionResult GetSiteUrl(string id)
        {
            var siteUrl = _repository.GetUrlById(id);
            if (siteUrl == null)
            {
                return BadRequest();
            }
            siteUrl.LastViewed = DateTime.Now;
            siteUrl.ViewsCount++;
            _repository.Update(siteUrl);
            return Ok(siteUrl);
            //var response = Request.CreateResponse(HttpStatusCode.OK);
            //response.Content = new StringContent(siteUrl.JsonData, Encoding.UTF8, "application/json");
            //return ResponseMessage(response);
        }

        // POST api/urls
        public IHttpActionResult PostSiteUrl(SiteUrl siteUrl)
        {
            siteUrl.CreationDate = DateTime.Now;
            siteUrl.LastViewed = DateTime.Now;
            siteUrl.ModifyKey = GetRandomString(10);
            siteUrl.ViewsCount = 0;
            var id = GetRandomString(10);
            while (_repository.GetUrlById(id) != null)
            {
                id = GetRandomString(10);
            }
            siteUrl.Id = id;
            _repository.AddUrl(siteUrl);
            return Ok(siteUrl);
        }

        // PUT api/urls/abc
        public IHttpActionResult PutSiteUrl(string id, SiteUrl siteUrl)
        {
            var siteUrlFromDatabase = _repository.GetUrlByModifyKey(id);
            if (siteUrlFromDatabase == null)
            {
                return NotFound();
            }
            siteUrlFromDatabase.JsonData = siteUrl.JsonData;
            siteUrlFromDatabase.LastViewed = DateTime.Now;
            _repository.Update(siteUrlFromDatabase);
            return Ok(siteUrlFromDatabase);
        }

        private static string GetRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random(DateTime.Now.Millisecond);
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repository.Dispose();
                _repository = null;
            }

            base.Dispose(disposing);
        }
    }
}