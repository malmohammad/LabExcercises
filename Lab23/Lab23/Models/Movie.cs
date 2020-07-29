using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab23.Models
{
    public class Movie
    {
        private string v;
        private object action;
        private TypeGenre comedy;

        public Movie(string v, TypeGenre comedy)
        {
            this.v = v;
            this.comedy = comedy;
        }

        public Movie(string v, Movie movie, object action)
        {
            this.v = v;
            this.action = action;
        }

        public string Title { get; set; }
        public TypeGenre Genre { get; set; }

        public int RunTime { get; set; }


    }
}
