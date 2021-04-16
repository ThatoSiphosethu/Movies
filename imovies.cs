using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Movielibrary
{
    public interface IMovies 
    {
        void ReadMovies(Movie movie);

        void AddMovie(Movie movie);
    }

    
}