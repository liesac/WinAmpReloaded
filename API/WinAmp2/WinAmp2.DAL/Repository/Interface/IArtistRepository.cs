using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAmp2.COMMON.DTOs.PlayListProject;

namespace WinAmp2.DAL.Repository.Interface
{
    public interface IArtistRepository
    {
        IList<ArtistDTO> getAllArtists();
    }
}
