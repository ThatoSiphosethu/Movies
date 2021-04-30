using System.Collections.Generic;

namespace Movielibrary
{
    public class MovieFile : IContext

    {
        private readonly IFileWriter location;
        public MovieFile(IFileWriter fileWriter)
        {
            location = fileWriter;
        }
        public void AddMovie(Movie movie)
        {
            location.Add(movie);
        }

        public List<Movie> GetMovies()
        {
            return location.GetAll();
        }
    }
}