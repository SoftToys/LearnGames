using LearnGames.Web.Models;
using System.Linq;
using System.Web.Mvc;

namespace LearnGames.Web.Controllers
{
    public class HomeController : Controller
    {
        IGamesRepo _repo = new XmlRepo();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MatchingGame(int id)
        {
            ViewData.Add("GameTypeId", id);
            return View();
            //return new JsonResult() { Data = new { } };

        }






        [HttpGet]
        public JsonResult GameList()
        {
            return new JsonResult() { Data = _repo.GetGames(), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        [HttpGet]
        public JsonResult Game(int id)
        {
            return new JsonResult()
            {
                Data = _repo.Get(id),
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
        //[HttpGet]
        //public JsonResult FindingOddGame(int id)
        //{
        //    var game = _repo.Get(id);
        //    if (game.Objects == null || game.Objects.Count == 0)
        //    {
        //        var objects = _repo.GetAllObjects();
        //        var propLevel = 2;

        //        objects = game.Objects.TakeWhile(o => o)

        //    }

        //    return new JsonResult()
        //    {
        //        Data = game,
        //        JsonRequestBehavior = JsonRequestBehavior.AllowGet
        //    };
        //}



    }
}