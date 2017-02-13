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
    public class GenreRepository : IGenreRepository
    {
        public IList<GenreDto> getAllGenres()
        {
            using (PlayListsProjectEntities context = new PlayListsProjectEntities())
            {
                return context.Genre.Select(x => new GenreDto
                {
                    IdGenre = x.IdGenre,
                    Name = x.Name
                }).ToList();
            }
        }

        public GenreDto getGenreById(int id)
        {
            using (PlayListsProjectEntities context = new PlayListsProjectEntities())
            {
                return context.Genre.Where(x => x.IdGenre == id).Select(y => new GenreDto
                {
                    IdGenre = y.IdGenre,
                    Name = y.Name
                }).First();
            }

        }

        public GenreDto createOrUpdateGenre(GenreDto newGenre)
        {
            using (PlayListsProjectEntities context = new PlayListsProjectEntities())
            {
                GenreDto genreToReturn = new GenreDto();
                if (newGenre.IdGenre == null)//create
                {
                    var createGenre = new Genre
                    {
                        Name = newGenre.Name
                    };

                    context.Genre.Add(createGenre);

                    genreToReturn.IdGenre = createGenre.IdGenre;
                    genreToReturn.Name = createGenre.Name;
                }
                else //update
                {
                    var genreFound = context.Genre.Where(x => x.IdGenre == newGenre.IdGenre).Count();

                    if (genreFound > 0)
                    {
                        var updateGenre = new Genre
                        {
                            IdGenre = newGenre.IdGenre.Value,
                            Name = newGenre.Name
                        };

                        context.Genre.Attach(updateGenre);
                        context.Entry(updateGenre).State = System.Data.Entity.EntityState.Modified;

                        genreToReturn.IdGenre = updateGenre.IdGenre;
                        genreToReturn.Name = updateGenre.Name;
                    }
                    else {
                        return new GenreDto();
                    }

                }

                context.SaveChanges();

                return genreToReturn;
            }
        }

        public GenreDto deleteGenreById(int genreId)
        {
            using (PlayListsProjectEntities context = new PlayListsProjectEntities())
            {

                var genreFound = context.Genre.Where(x => x.IdGenre == genreId);

                Genre genreToDelete = new Genre
                {
                    IdGenre = genreId
                };

                if (genreFound.Count() > 0)
                {
                    context.Genre.Attach(genreToDelete);
                    context.Genre.Remove(genreToDelete);
                }
                else {
                    return new GenreDto();
                }

                context.SaveChanges();

                return new GenreDto
                {
                    IdGenre = genreToDelete.IdGenre,
                    Name = genreToDelete.Name
                };

            }
        }
    }
}
