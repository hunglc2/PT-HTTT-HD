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
    builder.EntitySet<CUSTOMER>("CUSTOMERs");
    builder.EntitySet<ACCOUNT>("ACCOUNTs"); 
    builder.EntitySet<BRANCH>("BRANCHes"); 
    builder.EntitySet<SAVINGS_ACCOUNT>("SAVINGS_ACCOUNT"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class CUSTOMERsController : ODataController
    {
        private BANK_MANAGEMENTEntities db = new BANK_MANAGEMENTEntities();

        // GET: odata/CUSTOMERs
        [EnableQuery]
        public IQueryable<CUSTOMER> GetCUSTOMERs()
        {
            return db.CUSTOMERs;
        }

        // GET: odata/CUSTOMERs(5)
        [EnableQuery]
        public SingleResult<CUSTOMER> GetCUSTOMER([FromODataUri] int key)
        {
            return SingleResult.Create(db.CUSTOMERs.Where(cUSTOMER => cUSTOMER.idCUSTOMER == key));
        }

        // PUT: odata/CUSTOMERs(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<CUSTOMER> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            CUSTOMER cUSTOMER = db.CUSTOMERs.Find(key);
            if (cUSTOMER == null)
            {
                return NotFound();
            }

            patch.Put(cUSTOMER);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CUSTOMERExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(cUSTOMER);
        }

        // POST: odata/CUSTOMERs
        public IHttpActionResult Post(CUSTOMER cUSTOMER)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CUSTOMERs.Add(cUSTOMER);
            db.SaveChanges();

            return Created(cUSTOMER);
        }

        // PATCH: odata/CUSTOMERs(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<CUSTOMER> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            CUSTOMER cUSTOMER = db.CUSTOMERs.Find(key);
            if (cUSTOMER == null)
            {
                return NotFound();
            }

            patch.Patch(cUSTOMER);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CUSTOMERExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(cUSTOMER);
        }

        // DELETE: odata/CUSTOMERs(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            CUSTOMER cUSTOMER = db.CUSTOMERs.Find(key);
            if (cUSTOMER == null)
            {
                return NotFound();
            }

            db.CUSTOMERs.Remove(cUSTOMER);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/CUSTOMERs(5)/ACCOUNTs
        [EnableQuery]
        public IQueryable<ACCOUNT> GetACCOUNTs([FromODataUri] int key)
        {
            return db.CUSTOMERs.Where(m => m.idCUSTOMER == key).SelectMany(m => m.ACCOUNTs);
        }

        // GET: odata/CUSTOMERs(5)/BRANCH
        [EnableQuery]
        public SingleResult<BRANCH> GetBRANCH([FromODataUri] int key)
        {
            return SingleResult.Create(db.CUSTOMERs.Where(m => m.idCUSTOMER == key).Select(m => m.BRANCH));
        }

        // GET: odata/CUSTOMERs(5)/SAVINGS_ACCOUNT
        [EnableQuery]
        public IQueryable<SAVINGS_ACCOUNT> GetSAVINGS_ACCOUNT([FromODataUri] int key)
        {
            return db.CUSTOMERs.Where(m => m.idCUSTOMER == key).SelectMany(m => m.SAVINGS_ACCOUNT);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CUSTOMERExists(int key)
        {
            return db.CUSTOMERs.Count(e => e.idCUSTOMER == key) > 0;
        }
    }
}
