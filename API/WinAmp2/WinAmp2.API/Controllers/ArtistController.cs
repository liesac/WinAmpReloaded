using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WinAmp2.BUSINESS.Services.Implementation;
using WinAmp2.BUSINESS.Services.Interface;
using WinAmp2.COMMON.DTOs.PlayListProject;

namespace WinAmp2.API.Controllers
{
    public class ArtistController : ApiController
    {
        // GET: api/Artist
        public IList<ArtistDTO> Get()
        {
            IArtistService artists = new ArtistService();

            return artists.getAllArtists();
        }

        // GET: api/Artist/5
        public string Get(int id)
        {
            return "value" + id;
        }

        // POST: api/Artist
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Artist/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Artist/5
        public void Delete(int id)
        {
        }
    }
}
