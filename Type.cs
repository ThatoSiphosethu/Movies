using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movielibrary
{
    public abstract class Type
    {
        public int ID { get; set; }
        public string Title { get; set; }
       public abstract string Display();

        //public abstract void setMovieItem(int mID, String mName);
        //public abstract String getMovies();
    }
}
