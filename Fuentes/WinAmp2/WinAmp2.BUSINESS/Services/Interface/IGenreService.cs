using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAmp2.COMMON.DTOs.PlayListsProject;

namespace WinAmp2.BUSINESS.Services.Interface
{
    public interface IGenreService
    {
        IList<GenreDto> getAllGenres();
        GenreDto getGenreById(int id);
        GenreDto createOrUpdateGenre(GenreDto newGenre);
        GenreDto deleteGenreById(int idGenre);
    }
}
