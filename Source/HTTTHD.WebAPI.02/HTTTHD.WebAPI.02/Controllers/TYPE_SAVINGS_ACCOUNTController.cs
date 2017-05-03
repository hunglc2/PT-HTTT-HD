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
    builder.EntitySet<TYPE_SAVINGS_ACCOUNT>("TYPE_SAVINGS_ACCOUNT");
    builder.EntitySet<SAVINGS_ACCOUNT>("SAVINGS_ACCOUNT"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class TYPE_SAVINGS_ACCOUNTController : ODataController
    {
        private BANK_MANAGEMENTEntities db = new BANK_MANAGEMENTEntities();

        // GET: odata/TYPE_SAVINGS_ACCOUNT
        [EnableQuery]
        public IQueryable<TYPE_SAVINGS_ACCOUNT> GetTYPE_SAVINGS_ACCOUNT()
        {
            return db.TYPE_SAVINGS_ACCOUNT;
        }

        // GET: odata/TYPE_SAVINGS_ACCOUNT(5)
        [EnableQuery]
        public SingleResult<TYPE_SAVINGS_ACCOUNT> GetTYPE_SAVINGS_ACCOUNT([FromODataUri] int key)
        {
            return SingleResult.Create(db.TYPE_SAVINGS_ACCOUNT.Where(tYPE_SAVINGS_ACCOUNT => tYPE_SAVINGS_ACCOUNT.idTYPE_SAVINGS_ACCOUNT == key));
        }

        // PUT: odata/TYPE_SAVINGS_ACCOUNT(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<TYPE_SAVINGS_ACCOUNT> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TYPE_SAVINGS_ACCOUNT tYPE_SAVINGS_ACCOUNT = db.TYPE_SAVINGS_ACCOUNT.Find(key);
            if (tYPE_SAVINGS_ACCOUNT == null)
            {
                return NotFound();
            }

            patch.Put(tYPE_SAVINGS_ACCOUNT);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TYPE_SAVINGS_ACCOUNTExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(tYPE_SAVINGS_ACCOUNT);
        }

        // POST: odata/TYPE_SAVINGS_ACCOUNT
        public IHttpActionResult Post(TYPE_SAVINGS_ACCOUNT tYPE_SAVINGS_ACCOUNT)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TYPE_SAVINGS_ACCOUNT.Add(tYPE_SAVINGS_ACCOUNT);
            db.SaveChanges();

            return Created(tYPE_SAVINGS_ACCOUNT);
        }

        // PATCH: odata/TYPE_SAVINGS_ACCOUNT(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<TYPE_SAVINGS_ACCOUNT> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TYPE_SAVINGS_ACCOUNT tYPE_SAVINGS_ACCOUNT = db.TYPE_SAVINGS_ACCOUNT.Find(key);
            if (tYPE_SAVINGS_ACCOUNT == null)
            {
                return NotFound();
            }

            patch.Patch(tYPE_SAVINGS_ACCOUNT);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TYPE_SAVINGS_ACCOUNTExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(tYPE_SAVINGS_ACCOUNT);
        }

        // DELETE: odata/TYPE_SAVINGS_ACCOUNT(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            TYPE_SAVINGS_ACCOUNT tYPE_SAVINGS_ACCOUNT = db.TYPE_SAVINGS_ACCOUNT.Find(key);
            if (tYPE_SAVINGS_ACCOUNT == null)
            {
                return NotFound();
            }

            db.TYPE_SAVINGS_ACCOUNT.Remove(tYPE_SAVINGS_ACCOUNT);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/TYPE_SAVINGS_ACCOUNT(5)/SAVINGS_ACCOUNT
        [EnableQuery]
        public IQueryable<SAVINGS_ACCOUNT> GetSAVINGS_ACCOUNT([FromODataUri] int key)
        {
            return db.TYPE_SAVINGS_ACCOUNT.Where(m => m.idTYPE_SAVINGS_ACCOUNT == key).SelectMany(m => m.SAVINGS_ACCOUNT);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TYPE_SAVINGS_ACCOUNTExists(int key)
        {
            return db.TYPE_SAVINGS_ACCOUNT.Count(e => e.idTYPE_SAVINGS_ACCOUNT == key) > 0;
        }
    }
}
