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
    builder.EntitySet<SAVINGS_ACCOUNT>("SAVINGS_ACCOUNT");
    builder.EntitySet<ACCOUNT>("ACCOUNTs"); 
    builder.EntitySet<BRANCH>("BRANCHes"); 
    builder.EntitySet<CUSTOMER>("CUSTOMERs"); 
    builder.EntitySet<TYPE_SAVINGS_ACCOUNT>("TYPE_SAVINGS_ACCOUNT"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class SAVINGS_ACCOUNTController : ODataController
    {
        private BANK_MANAGEMENTEntities db = new BANK_MANAGEMENTEntities();

        // GET: odata/SAVINGS_ACCOUNT
        [EnableQuery]
        public IQueryable<SAVINGS_ACCOUNT> GetSAVINGS_ACCOUNT()
        {
            return db.SAVINGS_ACCOUNT;
        }

        // GET: odata/SAVINGS_ACCOUNT(5)
        [EnableQuery]
        public SingleResult<SAVINGS_ACCOUNT> GetSAVINGS_ACCOUNT([FromODataUri] int key)
        {
            return SingleResult.Create(db.SAVINGS_ACCOUNT.Where(sAVINGS_ACCOUNT => sAVINGS_ACCOUNT.idSAVINGS_ACCOUNT == key));
        }

        // PUT: odata/SAVINGS_ACCOUNT(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<SAVINGS_ACCOUNT> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            SAVINGS_ACCOUNT sAVINGS_ACCOUNT = db.SAVINGS_ACCOUNT.Find(key);
            if (sAVINGS_ACCOUNT == null)
            {
                return NotFound();
            }

            patch.Put(sAVINGS_ACCOUNT);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SAVINGS_ACCOUNTExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(sAVINGS_ACCOUNT);
        }

        // POST: odata/SAVINGS_ACCOUNT
        public IHttpActionResult Post(SAVINGS_ACCOUNT sAVINGS_ACCOUNT)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SAVINGS_ACCOUNT.Add(sAVINGS_ACCOUNT);
            db.SaveChanges();

            return Created(sAVINGS_ACCOUNT);
        }

        // PATCH: odata/SAVINGS_ACCOUNT(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<SAVINGS_ACCOUNT> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            SAVINGS_ACCOUNT sAVINGS_ACCOUNT = db.SAVINGS_ACCOUNT.Find(key);
            if (sAVINGS_ACCOUNT == null)
            {
                return NotFound();
            }

            patch.Patch(sAVINGS_ACCOUNT);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SAVINGS_ACCOUNTExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(sAVINGS_ACCOUNT);
        }

        // DELETE: odata/SAVINGS_ACCOUNT(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            SAVINGS_ACCOUNT sAVINGS_ACCOUNT = db.SAVINGS_ACCOUNT.Find(key);
            if (sAVINGS_ACCOUNT == null)
            {
                return NotFound();
            }

            db.SAVINGS_ACCOUNT.Remove(sAVINGS_ACCOUNT);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/SAVINGS_ACCOUNT(5)/ACCOUNT
        [EnableQuery]
        public SingleResult<ACCOUNT> GetACCOUNT([FromODataUri] int key)
        {
            return SingleResult.Create(db.SAVINGS_ACCOUNT.Where(m => m.idSAVINGS_ACCOUNT == key).Select(m => m.ACCOUNT));
        }

        // GET: odata/SAVINGS_ACCOUNT(5)/BRANCH
        [EnableQuery]
        public SingleResult<BRANCH> GetBRANCH([FromODataUri] int key)
        {
            return SingleResult.Create(db.SAVINGS_ACCOUNT.Where(m => m.idSAVINGS_ACCOUNT == key).Select(m => m.BRANCH));
        }

        // GET: odata/SAVINGS_ACCOUNT(5)/CUSTOMER
        [EnableQuery]
        public SingleResult<CUSTOMER> GetCUSTOMER([FromODataUri] int key)
        {
            return SingleResult.Create(db.SAVINGS_ACCOUNT.Where(m => m.idSAVINGS_ACCOUNT == key).Select(m => m.CUSTOMER));
        }

        // GET: odata/SAVINGS_ACCOUNT(5)/TYPE_SAVINGS_ACCOUNT
        [EnableQuery]
        public SingleResult<TYPE_SAVINGS_ACCOUNT> GetTYPE_SAVINGS_ACCOUNT([FromODataUri] int key)
        {
            return SingleResult.Create(db.SAVINGS_ACCOUNT.Where(m => m.idSAVINGS_ACCOUNT == key).Select(m => m.TYPE_SAVINGS_ACCOUNT));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SAVINGS_ACCOUNTExists(int key)
        {
            return db.SAVINGS_ACCOUNT.Count(e => e.idSAVINGS_ACCOUNT == key) > 0;
        }
    }
}
