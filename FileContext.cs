using System.Collections.Generic;

namespace Movielibrary
{
    public interface IContext
    {
        void AddMovie(Movie movie);
        List<Movie> GetMovies();
    }
}