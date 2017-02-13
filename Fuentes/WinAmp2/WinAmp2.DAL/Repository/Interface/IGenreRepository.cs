using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAmp2.COMMON.DTOs.PlayListsProject;

namespace WinAmp2.DAL.Repository.Interface
{
    public interface IGenreRepository
    {
        IList<GenreDto> getAllGenres();
        GenreDto getGenreById(int id);
        GenreDto createOrUpdateGenre(GenreDto newGenre);
        GenreDto deleteGenreById(int genreId);
    }
}
