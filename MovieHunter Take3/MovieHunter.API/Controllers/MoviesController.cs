using MovieHunter.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;

namespace MovieHunter.API.Controllers
{
    /// <summary>
    /// API for Movies
    /// </summary>
    public class MoviesController : ApiController
    {
        /// <summary>
        /// Retrieves all movies from the repository
        /// </summary>
        /// <returns></returns>
        /// <example>GET api/movies</example>
        [ResponseType(typeof(Movie))]
        public IHttpActionResult Get()
        {
            try
            {
                var movieRepository = new MovieRepository();
                return Ok(movieRepository.Retrieve().AsQueryable());

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>
        /// Retrieves a single from the repository
        /// </summary>
        /// <returns></returns>
        /// <example>GET api/movies/5</example>
        [ResponseType(typeof(Movie))]
        public IHttpActionResult Get(int id)
        {
            try
            {
                var moviesRepository = new Models.MovieRepository();
                var movies = moviesRepository.Retrieve();
                var movie = movies.FirstOrDefault(t => t.movieId == id);
                if (movie == null)
                {
                    return NotFound();
                }
                return Ok(movie);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
