using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using HTTTHD.WebAPI._02.Models;

namespace HTTTHD.WebAPI._02.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using HTTTHD.WebAPI._02.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<OWNER>("OWNERs");
    builder.EntitySet<BRANCH>("BRANCHes"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class OWNERsController : ODataController
    {
        private BANK_MANAGEMENTEntities db = new BANK_MANAGEMENTEntities();

        // GET: odata/OWNERs
        [EnableQuery]
        public IQueryable<OWNER> GetOWNERs()
        {
            return db.OWNERs;
        }

        // GET: odata/OWNERs(5)
        [EnableQuery]
        public SingleResult<OWNER> GetOWNER([FromODataUri] int key)
        {
            return SingleResult.Create(db.OWNERs.Where(oWNER => oWNER.idOWNER == key));
        }

        // PUT: odata/OWNERs(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<OWNER> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            OWNER oWNER = db.OWNERs.Find(key);
            if (oWNER == null)
            {
                return NotFound();
            }

            patch.Put(oWNER);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OWNERExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(oWNER);
        }

        // POST: odata/OWNERs
        public IHttpActionResult Post(OWNER oWNER)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OWNERs.Add(oWNER);
            db.SaveChanges();

            return Created(oWNER);
        }

        // PATCH: odata/OWNERs(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<OWNER> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            OWNER oWNER = db.OWNERs.Find(key);
            if (oWNER == null)
            {
                return NotFound();
            }

            patch.Patch(oWNER);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OWNERExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(oWNER);
        }

        // DELETE: odata/OWNERs(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            OWNER oWNER = db.OWNERs.Find(key);
            if (oWNER == null)
            {
                return NotFound();
            }

            db.OWNERs.Remove(oWNER);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/OWNERs(5)/BRANCHes
        [EnableQuery]
        public IQueryable<BRANCH> GetBRANCHes([FromODataUri] int key)
        {
            return db.OWNERs.Where(m => m.idOWNER == key).SelectMany(m => m.BRANCHes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OWNERExists(int key)
        {
            return db.OWNERs.Count(e => e.idOWNER == key) > 0;
        }
    }
}
