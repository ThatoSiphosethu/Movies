﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class Movie : Type
    {
        public string[] Genres { get; set; }
        public int Id { get; internal set; }

        public override string Display()
        {
            throw new NotImplementedException();
        }
    }
}
