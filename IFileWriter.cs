using System.Collections.Generic;

namespace Movielibrary
{
    public interface IFileWriter
    {
        void Read(Movie movie);
        void Write();
        void Search();
        List<Movie> GetAll();
        void Add(Movie movie);
    }
}