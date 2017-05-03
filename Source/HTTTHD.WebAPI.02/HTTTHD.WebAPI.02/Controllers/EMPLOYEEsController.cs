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
    builder.EntitySet<EMPLOYEE>("EMPLOYEEs");
    builder.EntitySet<BRANCH>("BRANCHes"); 
    builder.EntitySet<POSITION_EMP>("POSITION_EMP"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class EMPLOYEEsController : ODataController
    {
        private BANK_MANAGEMENTEntities db = new BANK_MANAGEMENTEntities();

        // GET: odata/EMPLOYEEs
        [EnableQuery]
        public IQueryable<EMPLOYEE> GetEMPLOYEEs()
        {
            return db.EMPLOYEEs;
        }

        // GET: odata/EMPLOYEEs(5)
        [EnableQuery]
        public SingleResult<EMPLOYEE> GetEMPLOYEE([FromODataUri] int key)
        {
            return SingleResult.Create(db.EMPLOYEEs.Where(eMPLOYEE => eMPLOYEE.idEMPLOYEE == key));
        }

        // PUT: odata/EMPLOYEEs(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<EMPLOYEE> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            EMPLOYEE eMPLOYEE = db.EMPLOYEEs.Find(key);
            if (eMPLOYEE == null)
            {
                return NotFound();
            }

            patch.Put(eMPLOYEE);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EMPLOYEEExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(eMPLOYEE);
        }

        // POST: odata/EMPLOYEEs
        public IHttpActionResult Post(EMPLOYEE eMPLOYEE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EMPLOYEEs.Add(eMPLOYEE);
            db.SaveChanges();

            return Created(eMPLOYEE);
        }

        // PATCH: odata/EMPLOYEEs(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<EMPLOYEE> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            EMPLOYEE eMPLOYEE = db.EMPLOYEEs.Find(key);
            if (eMPLOYEE == null)
            {
                return NotFound();
            }

            patch.Patch(eMPLOYEE);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EMPLOYEEExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(eMPLOYEE);
        }

        // DELETE: odata/EMPLOYEEs(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            EMPLOYEE eMPLOYEE = db.EMPLOYEEs.Find(key);
            if (eMPLOYEE == null)
            {
                return NotFound();
            }

            db.EMPLOYEEs.Remove(eMPLOYEE);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/EMPLOYEEs(5)/BRANCH
        [EnableQuery]
        public SingleResult<BRANCH> GetBRANCH([FromODataUri] int key)
        {
            return SingleResult.Create(db.EMPLOYEEs.Where(m => m.idEMPLOYEE == key).Select(m => m.BRANCH));
        }

        // GET: odata/EMPLOYEEs(5)/POSITION_EMP
        [EnableQuery]
        public SingleResult<POSITION_EMP> GetPOSITION_EMP([FromODataUri] int key)
        {
            return SingleResult.Create(db.EMPLOYEEs.Where(m => m.idEMPLOYEE == key).Select(m => m.POSITION_EMP));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EMPLOYEEExists(int key)
        {
            return db.EMPLOYEEs.Count(e => e.idEMPLOYEE == key) > 0;
        }
    }
}
