using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAmp2.BUSINESS.Services.Interface;
using WinAmp2.COMMON.DTOs.PlayListsProject;
using WinAmp2.DAL.Repository.Implementation;
using WinAmp2.DAL.Repository.Interface;

namespace WinAmp2.BUSINESS.Services.Implementation
{
    public class GenreService : IGenreService
    {
        IGenreRepository genres = new GenreRepository();
        public IList<GenreDto> getAllGenres() {
            return genres.getAllGenres();
        }

        public GenreDto getGenreById(int id) {
            return genres.getGenreById(id);
        }

        public GenreDto createOrUpdateGenre(GenreDto newGenre)
        {
            return genres.createOrUpdateGenre(newGenre);
        }

        public GenreDto deleteGenreById(int idGenre)
        {
            return genres.deleteGenreById(idGenre);
        }
    }
}
