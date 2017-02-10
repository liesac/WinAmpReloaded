using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAmp2.COMMON.DTOs.PlayListProject
{
    class AlbumSongArtistDTO
    {
        public int? IdAlbumSongArtist { get; set; }
        public int IdArtist { get; set; }
        public int IdAlbum { get; set; }
        public int IdSong { get; set; }
    }
}
