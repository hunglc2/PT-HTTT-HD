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
    builder.EntitySet<BRANCH>("BRANCHes");
    builder.EntitySet<ACCOUNT>("ACCOUNTs"); 
    builder.EntitySet<OWNER>("OWNERs"); 
    builder.EntitySet<CUSTOMER>("CUSTOMERs"); 
    builder.EntitySet<EMPLOYEE>("EMPLOYEEs"); 
    builder.EntitySet<SAVINGS_ACCOUNT>("SAVINGS_ACCOUNT"); 
    builder.EntitySet<TRANSACTION>("TRANSACTIONS"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class BRANCHesController : ODataController
    {
        private BANK_MANAGEMENTEntities db = new BANK_MANAGEMENTEntities();

        // GET: odata/BRANCHes
        [EnableQuery]
        public IQueryable<BRANCH> GetBRANCHes()
        {
            return db.BRANCHes;
        }

        // GET: odata/BRANCHes(5)
        [EnableQuery]
        public SingleResult<BRANCH> GetBRANCH([FromODataUri] int key)
        {
            return SingleResult.Create(db.BRANCHes.Where(bRANCH => bRANCH.idBranch == key));
        }

        // PUT: odata/BRANCHes(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<BRANCH> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            BRANCH bRANCH = db.BRANCHes.Find(key);
            if (bRANCH == null)
            {
                return NotFound();
            }

            patch.Put(bRANCH);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BRANCHExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(bRANCH);
        }

        // POST: odata/BRANCHes
        public IHttpActionResult Post(BRANCH bRANCH)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BRANCHes.Add(bRANCH);
            db.SaveChanges();

            return Created(bRANCH);
        }

        // PATCH: odata/BRANCHes(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<BRANCH> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            BRANCH bRANCH = db.BRANCHes.Find(key);
            if (bRANCH == null)
            {
                return NotFound();
            }

            patch.Patch(bRANCH);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BRANCHExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(bRANCH);
        }

        // DELETE: odata/BRANCHes(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            BRANCH bRANCH = db.BRANCHes.Find(key);
            if (bRANCH == null)
            {
                return NotFound();
            }

            db.BRANCHes.Remove(bRANCH);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/BRANCHes(5)/ACCOUNTs
        [EnableQuery]
        public IQueryable<ACCOUNT> GetACCOUNTs([FromODataUri] int key)
        {
            return db.BRANCHes.Where(m => m.idBranch == key).SelectMany(m => m.ACCOUNTs);
        }

        // GET: odata/BRANCHes(5)/OWNER
        [EnableQuery]
        public SingleResult<OWNER> GetOWNER([FromODataUri] int key)
        {
            return SingleResult.Create(db.BRANCHes.Where(m => m.idBranch == key).Select(m => m.OWNER));
        }

        // GET: odata/BRANCHes(5)/CUSTOMERs
        [EnableQuery]
        public IQueryable<CUSTOMER> GetCUSTOMERs([FromODataUri] int key)
        {
            return db.BRANCHes.Where(m => m.idBranch == key).SelectMany(m => m.CUSTOMERs);
        }

        // GET: odata/BRANCHes(5)/EMPLOYEEs
        [EnableQuery]
        public IQueryable<EMPLOYEE> GetEMPLOYEEs([FromODataUri] int key)
        {
            return db.BRANCHes.Where(m => m.idBranch == key).SelectMany(m => m.EMPLOYEEs);
        }

        // GET: odata/BRANCHes(5)/SAVINGS_ACCOUNT
        [EnableQuery]
        public IQueryable<SAVINGS_ACCOUNT> GetSAVINGS_ACCOUNT([FromODataUri] int key)
        {
            return db.BRANCHes.Where(m => m.idBranch == key).SelectMany(m => m.SAVINGS_ACCOUNT);
        }

        // GET: odata/BRANCHes(5)/TRANSACTIONS
        [EnableQuery]
        public IQueryable<TRANSACTION> GetTRANSACTIONS([FromODataUri] int key)
        {
            return db.BRANCHes.Where(m => m.idBranch == key).SelectMany(m => m.TRANSACTIONS);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BRANCHExists(int key)
        {
            return db.BRANCHes.Count(e => e.idBranch == key) > 0;
        }
    }
}
