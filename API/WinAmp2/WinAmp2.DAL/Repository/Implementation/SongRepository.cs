using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAmp2.COMMON.DTOs.PlayListProject;
using WinAmp2.DAL.EntityModel;
using WinAmp2.DAL.Repository.Interface;

namespace WinAmp2.DAL.Repository.Implementation
{
    public class SongRepository : ISongRepository
    {
        public IList<SongDTO> getAllSongs() {
            using (PlayListsProjectEntities context = new PlayListsProjectEntities())
            {
                return context.Song.Select(x => new SongDTO {
                    IdGenre = x.IdGenre,
                    IdSong = x.IdSong,
                    Length = x.Length,
                    Name = x.Name
                }).ToList();
            }
        }
    }
}
