using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WinAmp2.API.Controllers
{
    public class PlayListTypeController : ApiController
    {
        // GET: api/PlayListType
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PlayListType/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PlayListType
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PlayListType/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PlayListType/5
        public void Delete(int id)
        {
        }
    }
}
