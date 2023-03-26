using MinimalUwt.Models;
using MinimalUwt.Repositories;

namespace MinimalUwt.Services
{
    public class MovieService : IMovieService
    {
        public Movie Create(Movie movie) //this is about incrementing the id while creating a new movie
        {
            movie.Id = MovieRepository.Movies.Count + 1;//define id
            MovieRepository.Movies.Add(movie);//add id to list

            return movie;
        }

        public Movie Get(int id)
        {
            var movie = MovieRepository.Movies.FirstOrDefault(o => o.Id == id);//this is about finding the id

            if (movie is null) return null;//if id is not found return null

            return movie;
        }

        public List<Movie> List()//this is about returning the list of movies from the repository
        {
            var movies = MovieRepository.Movies;

            return movies;
        }

        public Movie Update(Movie newMovie)
        {
            var oldMovie = MovieRepository.Movies.FirstOrDefault(o => o.Id == newMovie.Id); //get the id of the old movie we want to update

            if (oldMovie is null) return null;

            oldMovie.Title = newMovie.Title;//update title
            oldMovie.Description = newMovie.Description;//update description
            oldMovie.Rating = newMovie.Rating; //update rating

            return newMovie;
        }

        public bool Delete(int id)
        {
            var oldMovie = MovieRepository.Movies.FirstOrDefault(o => o.Id == id);//this is about getting the old movie id we want to delete

            if (oldMovie is null) return false;

            MovieRepository.Movies.Remove(oldMovie);//and removing it from the repository

            return true;
        }
    }
}
