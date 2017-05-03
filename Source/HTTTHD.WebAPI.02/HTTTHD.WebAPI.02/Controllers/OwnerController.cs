using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HTTTHD.WebAPI._02.Models;

namespace HTTTHD.WebAPI._02.Controllers
{
    public class OwnerController : ApiController
    {
        [HttpGet]
        [Route("api/owner/all")]
        public IHttpActionResult getOwnerAll()
        {
            using (var ctx = new BANK_MANAGEMENTEntities())
            {
                var lstOwner = ctx.OWNERs
                    .Select(c => new {
                                        c.Name,
                                        c.Phone
                                     }
                    ).ToList();

                return Ok(lstOwner);
            }   
        }

        [HttpGet]
        [Route("api/owner/{id}")]
        public IHttpActionResult getOwnerByID(int id)
        {
            using (var ctx = new BANK_MANAGEMENTEntities())
            {
                var owner = ctx.OWNERs
                    .Where(c => c.idOWNER == id)
                    .Select(c => new
                                    {
                                        c.Name,
                                        c.Phone
                                    }
                    ).FirstOrDefault();

                if (owner == null)
                {
                    return StatusCode(HttpStatusCode.NoContent);
                }
                return Ok(owner);
            }
        }

        [HttpPost]
        [Route("api/owner/add")]
        public IHttpActionResult addOwner([FromBody]OWNER owner)
        {
            using (var ctx = new BANK_MANAGEMENTEntities())
            {
                ctx.OWNERs.Add(owner);
                ctx.SaveChanges();
                return StatusCode(HttpStatusCode.Created);
            }
        }

        [HttpPost]
        [Route("api/owner/addbatch")]
        public IHttpActionResult addBatchOwner([FromBody]OWNER [] lstOwner)
        {
            using (var ctx = new BANK_MANAGEMENTEntities())
            {
                foreach (OWNER owner in lstOwner)
                {
                    ctx.OWNERs.Add(owner);
                }
                int i = ctx.SaveChanges();
                return Created(String.Empty, i);
            }
        }

        [HttpDelete]
        [Route("api/owner/delete")]
        public IHttpActionResult deleteOwner([FromBody]OWNER owner)
        {
            using (var ctx = new BANK_MANAGEMENTEntities())
            {
                ctx.OWNERs.Remove(owner);
                int n = ctx.SaveChanges();
                return Ok(owner);
            }
        }

        [HttpDelete]
        [Route("api/owner/delete/{id}")]
        public IHttpActionResult deleteOwnerById([FromUri]int id)
        {
            using (var ctx = new BANK_MANAGEMENTEntities())
            {
                var owner = ctx.OWNERs.Where(r => r.idOWNER == id).FirstOrDefault();
                if (owner != null)
                {
                    ctx.OWNERs.Remove(owner);
                    ctx.SaveChanges();
                }
                return Ok(id);
            }
        }
    }
}
