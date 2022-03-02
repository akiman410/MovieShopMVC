using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        public List<MovieCardModel> GetTop30GrossingMovies()
        {
            // Call MovieRepository(Call the Database with Dapper or ER Core
            var movies = new List<MovieCardModel>()
            {
                new MovieCardModel{Id =1, Title="Judy", PoseterUrl ="https://images.unsplash.com/photo-1590179068383-b9c69aacebd3?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8bW92aWUlMjBwb3N0ZXJ8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60"},
                new MovieCardModel{Id =2, Title="Batman", PoseterUrl ="https://images.unsplash.com/photo-1509347528160-9a9e33742cdb?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NXx8bW92aWUlMjBwb3N0ZXJ8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60"},
                new MovieCardModel{Id =3, Title="Spiderman", PoseterUrl ="https://images.unsplash.com/photo-1635805737707-575885ab0820?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8N3x8bW92aWUlMjBwb3N0ZXJ8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60"},
                new MovieCardModel{Id =4, Title="", PoseterUrl =""},
                new MovieCardModel{Id =5, Title="", PoseterUrl =""},
                new MovieCardModel{Id =6, Title="", PoseterUrl =""},
                new MovieCardModel{Id =7, Title="", PoseterUrl =""},
                new MovieCardModel{Id =8, Title="", PoseterUrl =""},
            };
            return movies;
        }
    }
}
