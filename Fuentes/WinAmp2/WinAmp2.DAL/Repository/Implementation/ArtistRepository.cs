using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAmp2.COMMON.DTOs.PlayListsProject;
using WinAmp2.DAL.EntityModel;
using WinAmp2.DAL.Repository.Interface;

namespace WinAmp2.DAL.Repository.Implementation
{
    public class ArtistRepository : IArtistRepository
    {
        public IList<ArtistDto> getAllArtists() {
            using (PlayListsProjectEntities context = new PlayListsProjectEntities()) {
                return context.Artist.Select(x => new ArtistDto {
                    IdArtist = x.IdArtist,
                    LastName = x.LastName,
                    Name = x.Name,
                    Nationality = x.Nationality
                }).ToList();
            }
        }
    }
}
