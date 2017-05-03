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
    builder.EntitySet<TRANSACTION>("TRANSACTIONs");
    builder.EntitySet<ACCOUNT>("ACCOUNTs"); 
    builder.EntitySet<BRANCH>("BRANCHes"); 
    builder.EntitySet<TRANSACTION_TYPES>("TRANSACTION_TYPES"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class TRANSACTIONsController : ODataController
    {
        private BANK_MANAGEMENTEntities db = new BANK_MANAGEMENTEntities();

        // GET: odata/TRANSACTIONs
        [EnableQuery]
        public IQueryable<TRANSACTION> GetTRANSACTIONs()
        {
            return db.TRANSACTIONS;
        }

        // GET: odata/TRANSACTIONs(5)
        [EnableQuery]
        public SingleResult<TRANSACTION> GetTRANSACTION([FromODataUri] int key)
        {
            return SingleResult.Create(db.TRANSACTIONS.Where(tRANSACTION => tRANSACTION.idTRANSACTIONS == key));
        }

        // PUT: odata/TRANSACTIONs(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<TRANSACTION> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TRANSACTION tRANSACTION = db.TRANSACTIONS.Find(key);
            if (tRANSACTION == null)
            {
                return NotFound();
            }

            patch.Put(tRANSACTION);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TRANSACTIONExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(tRANSACTION);
        }

        // POST: odata/TRANSACTIONs
        public IHttpActionResult Post(TRANSACTION tRANSACTION)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TRANSACTIONS.Add(tRANSACTION);
            db.SaveChanges();

            return Created(tRANSACTION);
        }

        // PATCH: odata/TRANSACTIONs(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<TRANSACTION> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TRANSACTION tRANSACTION = db.TRANSACTIONS.Find(key);
            if (tRANSACTION == null)
            {
                return NotFound();
            }

            patch.Patch(tRANSACTION);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TRANSACTIONExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(tRANSACTION);
        }

        // DELETE: odata/TRANSACTIONs(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            TRANSACTION tRANSACTION = db.TRANSACTIONS.Find(key);
            if (tRANSACTION == null)
            {
                return NotFound();
            }

            db.TRANSACTIONS.Remove(tRANSACTION);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/TRANSACTIONs(5)/ACCOUNT
        [EnableQuery]
        public SingleResult<ACCOUNT> GetACCOUNT([FromODataUri] int key)
        {
            return SingleResult.Create(db.TRANSACTIONS.Where(m => m.idTRANSACTIONS == key).Select(m => m.ACCOUNT));
        }

        // GET: odata/TRANSACTIONs(5)/BRANCH
        [EnableQuery]
        public SingleResult<BRANCH> GetBRANCH([FromODataUri] int key)
        {
            return SingleResult.Create(db.TRANSACTIONS.Where(m => m.idTRANSACTIONS == key).Select(m => m.BRANCH));
        }

        // GET: odata/TRANSACTIONs(5)/TRANSACTION_TYPES
        [EnableQuery]
        public SingleResult<TRANSACTION_TYPES> GetTRANSACTION_TYPES([FromODataUri] int key)
        {
            return SingleResult.Create(db.TRANSACTIONS.Where(m => m.idTRANSACTIONS == key).Select(m => m.TRANSACTION_TYPES));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TRANSACTIONExists(int key)
        {
            return db.TRANSACTIONS.Count(e => e.idTRANSACTIONS == key) > 0;
        }
    }
}
