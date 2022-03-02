using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IMovieService
    {
        //Have all the business logic methods relating to Movies
        List<MovieCardModel> GetTop30GrossingMovies();
    }
}
