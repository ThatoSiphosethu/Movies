using System.Collections.Generic;
using Newtonsoft.Json;

namespace Movielibrary
{
    public class JsonConveter : IFileWriter
    {
        public void Add(Movie movie)
        {
            throw new System.NotImplementedException();
        }

        public List<Movie> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Read(Movie movie)
        {
           // List<Movie> movies = JsonConvert.SerializeObject<List<Movie>>("{title: Sample }");
        }

        public void Search()
        {
            throw new System.NotImplementedException();
        }

        public void Write()
        {
            List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>("{title: Sample }");
        }
    }
}