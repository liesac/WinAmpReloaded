using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAmp2.COMMON.DTOs.PlayListProject
{
    public class SongDTO
    {
        public int? IdSong { get; set; }
        public int IdGenre { get; set; }
        public string Name { get; set; }
        public TimeSpan Length { get; set; }
    }
}
