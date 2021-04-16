using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
namespace Movielibrary
{
    
    public class NewMovieFile : IMovieRepository
    {
        private readonly string file = Path.Combine ("Files", "movies.csv");
        private List<Movie> MovieList;
        public NewMovieFile()
        {
            if (!File.Exists(file)) throw FileNotFoundException($"Unable to locate {file}");
        }

        private Exception FileNotFoundException(string v)
        {
            throw new NotImplementedException();
        }

        public void Add(Movie movie)
        {
            var movies = GetAll();
            var lastMovie = movies.OrderBy(o => o.MovieId).Last();
            movie.MovieId = lastMovie.MovieID + 1;

            movies.Add(movie);

            using ( StreamWriter wr = new StreamWriter(file))
            {
                string json = JsonConvert.SerializeObject(MovieList, Formatting.Indented);
                wr.Write(json);
            }
        }

        public List<Movie> GetAll()
        {
            FileToList();
            return MovieList;
        }

        private void FileToList()
        {
            string json;
            using (StreamReader sr = new StreamReader(file))
            {
                json = sr.Read();
            }
            MovieList = JsonConvert.DeserializeObject<List>
                < Movie >> (json);
     
        }
        public int GetNextId()
        {
            FileToList();
            MovieList.Sort((x,y) => x.MovieID.CompareTo(y.MovieID));
            return MovieList.Last().MovieID + 1;
        }

        private class List
        {
        }
    }
    
    
    public interface IMovieRepository 
    {
        void Add(Movie movie);
        List<Movie> GetAll();
    }
    
}