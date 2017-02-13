using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WinAmp2.BUSINESS.Services.Implementation;
using WinAmp2.BUSINESS.Services.Interface;
using WinAmp2.COMMON.DTOs.PlayListsProject;

namespace WinAmp2.API.Controllers
{
    public class SongController : ApiController
    {
        // GET: api/Song
        public IList<SongDto> Get()
        {
            ISongService songs = new SongService();

            return songs.getAllSongs();
        }

        // GET: api/Song/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Song
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Song/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Song/5
        public void Delete(int id)
        {
        }
    }
}
