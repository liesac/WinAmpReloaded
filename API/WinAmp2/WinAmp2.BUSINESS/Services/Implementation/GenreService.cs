using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAmp2.BUSINESS.Services.Interface;
using WinAmp2.COMMON.DTOs.PlayListProject;
using WinAmp2.DAL.Repository.Implementation;
using WinAmp2.DAL.Repository.Interface;

namespace WinAmp2.BUSINESS.Services.Implementation
{
    public class GenreService : IGenreService
    {
        IGenreRepository genres = new GenreRepository();
        public IList<GenreDTO> getAllGenres() {
            return genres.getAllGenres();
        }

        public GenreDTO getGenreById(int id) {
            return genres.getGenreById(id);
        }

        public GenreDTO createOrUpdateGenre(GenreDTO newGenre)
        {
            return genres.createOrUpdateGenre(newGenre);
        }

        public GenreDTO deleteGenreById(int idGenre)
        {
            return genres.deleteGenreById(idGenre);
        }
    }
}
