using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAmp2.COMMON.DTOs.PlayListsProject;

namespace WinAmp2.BUSINESS.Services.Interface
{
    public interface IArtistService
    {
        IList<ArtistDto> getAllArtists();
    }
}
