using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace Movielibrary
{
    public class FileRepository : IFileWriter
    {
        
        private readonly string directory = Path.Combine(Environment.CurrentDirectory, "Files", "movies.json");
        public FileRepository()
        
        {
            if (!File.Exists(directory)) throw new FileNotFoundException($"Unable to locate {directory}");
        }

        public void Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Read(Movie movie)
        {
            var movies = GetAll();

            var lastMovie = movies.OrderBy(o => o.MovieId).Last();
            movie.MovieId = lastMovie.MovieId + 1;

            movies.Add(movie);

            using (var writer = new StreamWriter(directory))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                   // csv.Context.RegisterClassMap<MovieMap>();
                    csv.WriteRecords(movies);
                }
            }
            

        }

        public void Search()
        {
            throw new System.NotImplementedException();
        }

        public List<Movie> Write()
        {
            IEnumerable<Movie> records;

            using (var reader = new StreamReader(directory))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                   // csv.Context.RegisterClassMap<File>();

                    records = csv.GetRecords<Movie>().ToList();
                }
            }
            return new List<Movie>(records);
        }

        void IFileWriter.Write()
        {
            throw new NotImplementedException();//not sure
        }
    }
}