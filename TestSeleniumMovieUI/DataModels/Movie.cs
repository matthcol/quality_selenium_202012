using System;
using System.Collections.Generic;
using System.Text;

namespace MovieUI.Models
{
    public class Movie
    {
        public int? Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Duration { get; set; }

        public string PosterUri { get; set; }

    }
}
