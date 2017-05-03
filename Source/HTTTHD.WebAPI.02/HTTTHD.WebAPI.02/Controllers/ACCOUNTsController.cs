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
    builder.EntitySet<ACCOUNT>("ACCOUNTs");
    builder.EntitySet<ACCOUNT_TYPE>("ACCOUNT_TYPE"); 
    builder.EntitySet<BRANCH>("BRANCHes"); 
    builder.EntitySet<CUSTOMER>("CUSTOMERs"); 
    builder.EntitySet<SAVINGS_ACCOUNT>("SAVINGS_ACCOUNT"); 
    builder.EntitySet<TRANSACTION>("TRANSACTIONS"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class ACCOUNTsController : ODataController
    {
        private BANK_MANAGEMENTEntities db = new BANK_MANAGEMENTEntities();

        // GET: odata/ACCOUNTs
        [EnableQuery]
        public IQueryable<ACCOUNT> GetACCOUNTs()
        {
            return db.ACCOUNTs;
        }

        // GET: odata/ACCOUNTs(5)
        [EnableQuery]
        public SingleResult<ACCOUNT> GetACCOUNT([FromODataUri] int key)
        {
            return SingleResult.Create(db.ACCOUNTs.Where(aCCOUNT => aCCOUNT.idACCOUNT == key));
        }

        // PUT: odata/ACCOUNTs(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<ACCOUNT> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ACCOUNT aCCOUNT = db.ACCOUNTs.Find(key);
            if (aCCOUNT == null)
            {
                return NotFound();
            }

            patch.Put(aCCOUNT);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ACCOUNTExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(aCCOUNT);
        }

        // POST: odata/ACCOUNTs
        public IHttpActionResult Post(ACCOUNT aCCOUNT)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ACCOUNTs.Add(aCCOUNT);
            db.SaveChanges();

            return Created(aCCOUNT);
        }

        // PATCH: odata/ACCOUNTs(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<ACCOUNT> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ACCOUNT aCCOUNT = db.ACCOUNTs.Find(key);
            if (aCCOUNT == null)
            {
                return NotFound();
            }

            patch.Patch(aCCOUNT);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ACCOUNTExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(aCCOUNT);
        }

        // DELETE: odata/ACCOUNTs(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            ACCOUNT aCCOUNT = db.ACCOUNTs.Find(key);
            if (aCCOUNT == null)
            {
                return NotFound();
            }

            db.ACCOUNTs.Remove(aCCOUNT);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/ACCOUNTs(5)/ACCOUNT_TYPE
        [EnableQuery]
        public SingleResult<ACCOUNT_TYPE> GetACCOUNT_TYPE([FromODataUri] int key)
        {
            return SingleResult.Create(db.ACCOUNTs.Where(m => m.idACCOUNT == key).Select(m => m.ACCOUNT_TYPE));
        }

        // GET: odata/ACCOUNTs(5)/BRANCH
        [EnableQuery]
        public SingleResult<BRANCH> GetBRANCH([FromODataUri] int key)
        {
            return SingleResult.Create(db.ACCOUNTs.Where(m => m.idACCOUNT == key).Select(m => m.BRANCH));
        }

        // GET: odata/ACCOUNTs(5)/CUSTOMER
        [EnableQuery]
        public SingleResult<CUSTOMER> GetCUSTOMER([FromODataUri] int key)
        {
            return SingleResult.Create(db.ACCOUNTs.Where(m => m.idACCOUNT == key).Select(m => m.CUSTOMER));
        }

        // GET: odata/ACCOUNTs(5)/SAVINGS_ACCOUNT
        [EnableQuery]
        public IQueryable<SAVINGS_ACCOUNT> GetSAVINGS_ACCOUNT([FromODataUri] int key)
        {
            return db.ACCOUNTs.Where(m => m.idACCOUNT == key).SelectMany(m => m.SAVINGS_ACCOUNT);
        }

        // GET: odata/ACCOUNTs(5)/TRANSACTIONS
        [EnableQuery]
        public IQueryable<TRANSACTION> GetTRANSACTIONS([FromODataUri] int key)
        {
            return db.ACCOUNTs.Where(m => m.idACCOUNT == key).SelectMany(m => m.TRANSACTIONS);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ACCOUNTExists(int key)
        {
            return db.ACCOUNTs.Count(e => e.idACCOUNT == key) > 0;
        }
    }
}
