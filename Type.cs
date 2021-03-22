using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    abstract class Type
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public abstract string Display();
    }
}
