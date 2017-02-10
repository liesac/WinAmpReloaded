using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAmp2.BUSINESS.Services.Interface;
using WinAmp2.COMMON.DTOs.PlayListProject;
using WinAmp2.DAL.Repository.Implementation;
using WinAmp2.DAL.Repository.Interface;

namespace WinAmp2.BUSINESS.Services.Implementation
{
    public class ArtistService : IArtistService
    {
        public IList<ArtistDTO> getAllArtists() {
            IArtistRepository artist = new ArtistRepository();

            return artist.getAllArtists();
        }
    }
}
