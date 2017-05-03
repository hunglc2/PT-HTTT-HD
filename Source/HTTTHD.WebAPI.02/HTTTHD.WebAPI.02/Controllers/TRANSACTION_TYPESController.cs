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
    builder.EntitySet<TRANSACTION_TYPES>("TRANSACTION_TYPES");
    builder.EntitySet<TRANSACTION>("TRANSACTIONS"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class TRANSACTION_TYPESController : ODataController
    {
        private BANK_MANAGEMENTEntities db = new BANK_MANAGEMENTEntities();

        // GET: odata/TRANSACTION_TYPES
        [EnableQuery]
        public IQueryable<TRANSACTION_TYPES> GetTRANSACTION_TYPES()
        {
            return db.TRANSACTION_TYPES;
        }

        // GET: odata/TRANSACTION_TYPES(5)
        [EnableQuery]
        public SingleResult<TRANSACTION_TYPES> GetTRANSACTION_TYPES([FromODataUri] int key)
        {
            return SingleResult.Create(db.TRANSACTION_TYPES.Where(tRANSACTION_TYPES => tRANSACTION_TYPES.idTRANSACTION_TYPES == key));
        }

        // PUT: odata/TRANSACTION_TYPES(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<TRANSACTION_TYPES> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TRANSACTION_TYPES tRANSACTION_TYPES = db.TRANSACTION_TYPES.Find(key);
            if (tRANSACTION_TYPES == null)
            {
                return NotFound();
            }

            patch.Put(tRANSACTION_TYPES);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TRANSACTION_TYPESExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(tRANSACTION_TYPES);
        }

        // POST: odata/TRANSACTION_TYPES
        public IHttpActionResult Post(TRANSACTION_TYPES tRANSACTION_TYPES)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TRANSACTION_TYPES.Add(tRANSACTION_TYPES);
            db.SaveChanges();

            return Created(tRANSACTION_TYPES);
        }

        // PATCH: odata/TRANSACTION_TYPES(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<TRANSACTION_TYPES> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TRANSACTION_TYPES tRANSACTION_TYPES = db.TRANSACTION_TYPES.Find(key);
            if (tRANSACTION_TYPES == null)
            {
                return NotFound();
            }

            patch.Patch(tRANSACTION_TYPES);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TRANSACTION_TYPESExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(tRANSACTION_TYPES);
        }

        // DELETE: odata/TRANSACTION_TYPES(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            TRANSACTION_TYPES tRANSACTION_TYPES = db.TRANSACTION_TYPES.Find(key);
            if (tRANSACTION_TYPES == null)
            {
                return NotFound();
            }

            db.TRANSACTION_TYPES.Remove(tRANSACTION_TYPES);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/TRANSACTION_TYPES(5)/TRANSACTIONS
        [EnableQuery]
        public IQueryable<TRANSACTION> GetTRANSACTIONS([FromODataUri] int key)
        {
            return db.TRANSACTION_TYPES.Where(m => m.idTRANSACTION_TYPES == key).SelectMany(m => m.TRANSACTIONS);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TRANSACTION_TYPESExists(int key)
        {
            return db.TRANSACTION_TYPES.Count(e => e.idTRANSACTION_TYPES == key) > 0;
        }
    }
}
