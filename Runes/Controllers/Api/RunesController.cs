using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Services;
using Domain;
using Services.Interfaces;
using Infrastructure;

namespace Runes.Controllers
{
    public class RunesController : ApiController
    {
        private RuneService _service;
        public RunesController()
        {
            _service = new RuneService();
        }

        // GET: api/Runes
        public IList<Rune> Get()
        {
            return _service.GetList();
        }

        // GET: api/Runes/5
        public IHttpActionResult Get(int id)
        {
            var rune = _service.Get(id);
            if (rune == null) 
            {
                return NotFound();
            }
            return Ok(rune);
        }

        // POST: api/Runes
        public HttpResponseMessage Post(Rune rune)
        {
            if (ModelState.IsValid)
            {
                _service.Create(rune);
                return Request.CreateResponse(HttpStatusCode.OK, rune);
            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
        }

        // PUT: api/Runes/5
        public void Put(Rune rune)
        {
            if (ModelState.IsValid)
            {
                _service.Edit(rune);
            }
        }

        // DELETE: api/Runes/5
        public void Delete(int id)
        {
            _service.Delete(id);
        }

    }
}
