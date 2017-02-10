using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAmp2.COMMON.DTOs.PlayListProject
{
    public class PlayListDTO
    {
        public int? IdPlayList { get; set; }
        public int IdPayLIstType { get; set; }
        public string Name { get; set; }
        public string Score { get; set; }
        public string Visibility { get; set; }
    }
}
