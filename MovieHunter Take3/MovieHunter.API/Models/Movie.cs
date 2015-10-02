using System;
using System.Collections.Generic;

namespace MovieHunter.API.Models
{
    /// <summary>
    /// Defines a single movie
    /// </summary>
    public class Movie
    {
        public string description { get; set; }
        public string director { get; set; }
        public string imdbLink { get; set; }
        public string imageurl { get; set; }
        public int movieId { get; set; }
        public string mpaa { get; set; }
        public DateTime releaseDate { get; set; }
        public string title { get; set; }

    }
}