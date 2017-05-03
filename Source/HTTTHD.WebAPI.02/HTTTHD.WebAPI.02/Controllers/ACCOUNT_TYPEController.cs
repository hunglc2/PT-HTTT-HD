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
    builder.EntitySet<ACCOUNT_TYPE>("ACCOUNT_TYPE");
    builder.EntitySet<ACCOUNT>("ACCOUNTs"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class ACCOUNT_TYPEController : ODataController
    {
        private BANK_MANAGEMENTEntities db = new BANK_MANAGEMENTEntities();

        // GET: odata/ACCOUNT_TYPE
        [EnableQuery]
        public IQueryable<ACCOUNT_TYPE> GetACCOUNT_TYPE()
        {
            return db.ACCOUNT_TYPE;
        }

        // GET: odata/ACCOUNT_TYPE(5)
        [EnableQuery]
        public SingleResult<ACCOUNT_TYPE> GetACCOUNT_TYPE([FromODataUri] int key)
        {
            return SingleResult.Create(db.ACCOUNT_TYPE.Where(aCCOUNT_TYPE => aCCOUNT_TYPE.idACCOUNT_TYPE == key));
        }

        // PUT: odata/ACCOUNT_TYPE(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<ACCOUNT_TYPE> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ACCOUNT_TYPE aCCOUNT_TYPE = db.ACCOUNT_TYPE.Find(key);
            if (aCCOUNT_TYPE == null)
            {
                return NotFound();
            }

            patch.Put(aCCOUNT_TYPE);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ACCOUNT_TYPEExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(aCCOUNT_TYPE);
        }

        // POST: odata/ACCOUNT_TYPE
        public IHttpActionResult Post(ACCOUNT_TYPE aCCOUNT_TYPE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ACCOUNT_TYPE.Add(aCCOUNT_TYPE);
            db.SaveChanges();

            return Created(aCCOUNT_TYPE);
        }

        // PATCH: odata/ACCOUNT_TYPE(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<ACCOUNT_TYPE> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ACCOUNT_TYPE aCCOUNT_TYPE = db.ACCOUNT_TYPE.Find(key);
            if (aCCOUNT_TYPE == null)
            {
                return NotFound();
            }

            patch.Patch(aCCOUNT_TYPE);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ACCOUNT_TYPEExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(aCCOUNT_TYPE);
        }

        // DELETE: odata/ACCOUNT_TYPE(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            ACCOUNT_TYPE aCCOUNT_TYPE = db.ACCOUNT_TYPE.Find(key);
            if (aCCOUNT_TYPE == null)
            {
                return NotFound();
            }

            db.ACCOUNT_TYPE.Remove(aCCOUNT_TYPE);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/ACCOUNT_TYPE(5)/ACCOUNTs
        [EnableQuery]
        public IQueryable<ACCOUNT> GetACCOUNTs([FromODataUri] int key)
        {
            return db.ACCOUNT_TYPE.Where(m => m.idACCOUNT_TYPE == key).SelectMany(m => m.ACCOUNTs);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ACCOUNT_TYPEExists(int key)
        {
            return db.ACCOUNT_TYPE.Count(e => e.idACCOUNT_TYPE == key) > 0;
        }
    }
}
