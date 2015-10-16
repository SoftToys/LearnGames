using LearnGames.Web.Models;
using System.Collections.Generic;

namespace LearnGames.Web.Controllers
{
    internal interface IGamesRepo
    {
        //new List<Game>(new[] { new Game() { Description = "sdas", ImgUrl = "dasd", Name = "sd" } }
        IEnumerable<Game> GetGames();
        Game Get(int id);
    }
}