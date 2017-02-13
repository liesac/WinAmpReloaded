using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WinAmp2.API.Controllers
{
    public class PlayListController : ApiController
    {
        // GET: api/PlayList
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PlayList/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PlayList
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PlayList/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PlayList/5
        public void Delete(int id)
        {
        }
    }
}
