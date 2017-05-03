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
    builder.EntitySet<POSITION_EMP>("POSITION_EMP");
    builder.EntitySet<EMPLOYEE>("EMPLOYEEs"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class POSITION_EMPController : ODataController
    {
        private BANK_MANAGEMENTEntities db = new BANK_MANAGEMENTEntities();

        // GET: odata/POSITION_EMP
        [EnableQuery]
        public IQueryable<POSITION_EMP> GetPOSITION_EMP()
        {
            return db.POSITION_EMP;
        }

        // GET: odata/POSITION_EMP(5)
        [EnableQuery]
        public SingleResult<POSITION_EMP> GetPOSITION_EMP([FromODataUri] int key)
        {
            return SingleResult.Create(db.POSITION_EMP.Where(pOSITION_EMP => pOSITION_EMP.idPOSITION == key));
        }

        // PUT: odata/POSITION_EMP(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<POSITION_EMP> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            POSITION_EMP pOSITION_EMP = db.POSITION_EMP.Find(key);
            if (pOSITION_EMP == null)
            {
                return NotFound();
            }

            patch.Put(pOSITION_EMP);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!POSITION_EMPExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(pOSITION_EMP);
        }

        // POST: odata/POSITION_EMP
        public IHttpActionResult Post(POSITION_EMP pOSITION_EMP)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.POSITION_EMP.Add(pOSITION_EMP);
            db.SaveChanges();

            return Created(pOSITION_EMP);
        }

        // PATCH: odata/POSITION_EMP(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<POSITION_EMP> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            POSITION_EMP pOSITION_EMP = db.POSITION_EMP.Find(key);
            if (pOSITION_EMP == null)
            {
                return NotFound();
            }

            patch.Patch(pOSITION_EMP);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!POSITION_EMPExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(pOSITION_EMP);
        }

        // DELETE: odata/POSITION_EMP(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            POSITION_EMP pOSITION_EMP = db.POSITION_EMP.Find(key);
            if (pOSITION_EMP == null)
            {
                return NotFound();
            }

            db.POSITION_EMP.Remove(pOSITION_EMP);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/POSITION_EMP(5)/EMPLOYEEs
        [EnableQuery]
        public IQueryable<EMPLOYEE> GetEMPLOYEEs([FromODataUri] int key)
        {
            return db.POSITION_EMP.Where(m => m.idPOSITION == key).SelectMany(m => m.EMPLOYEEs);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool POSITION_EMPExists(int key)
        {
            return db.POSITION_EMP.Count(e => e.idPOSITION == key) > 0;
        }
    }
}
