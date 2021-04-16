using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movielibrary
{
    public class Movie : Type
    {
        public string[] Genres { get; set; }
        public int Id { get;  set; }
        public int MovieId { get; set; }
        public object MovieID { get; set; }

        public override string Display()
         {
             throw new NotImplementedException();
         }

        protected int movieID;
        protected String movieName;

        //public override string getMovies()
       // {
       //    return movieName;
        //}

       // public override void setMovieItem(int mID, string mName)
        //{
        //   movieID = mID;
          // movieName = mName;
        //}
    }
}
