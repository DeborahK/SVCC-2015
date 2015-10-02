using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace MovieHunter.API.Models
{
    /// <summary>
    /// Manages the set of movies.
    /// </summary>
    public class MovieRepository
    {
        /// <summary>
        /// Retrieves the list of movies from the repository.
        /// </summary>
        /// <returns></returns>
        public List<Movie> Retrieve()
        {
            var filePath = HttpContext.Current.Server.MapPath(@"~/App_Data/movies.json");
            var json = System.IO.File.ReadAllText(filePath);
            var movies = JsonConvert.DeserializeObject<List<Movie>>(json);

            return movies;
        }

        /// <summary>
        /// Saves a single movie back to the repository.
        /// </summary>
        /// <param name="value"></param>
        internal void Save(Movie value)
        {
            // Read in the existing movies
            var movies = this.Retrieve();

            // Locate and replace the item
            var itemIndex = movies.FindIndex(p => p.movieId == value.movieId);
            if (itemIndex > 0)
            {
                movies[itemIndex] = value;
            }
            else
            {
                movies.Add(value);
            }

            // Write out the Json
            var filePath = HttpContext.Current.Server.MapPath(@"~/App_Data/movies.json");
            var json = JsonConvert.SerializeObject(movies, Formatting.Indented);
            System.IO.File.WriteAllText(filePath, json);
        }
    }
}