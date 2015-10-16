using LearnGames.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Xml;

namespace LearnGames.Web.Models
{
    public class XmlRepo : IGamesRepo
    {
        List<Game> _games = new List<Game>();
        public XmlRepo()
        {
            XmlDocument doc = new XmlDocument();
            string file = HostingEnvironment.MapPath("~/Games.xml");
            doc.Load(file);
            int id = 0;
            foreach (XmlNode gameNode in doc.SelectNodes("//Game"))
            {
                var newGame = new Game()
                {
                    ID = ++id,
                    Description = gameNode["Description"].InnerText,
                    ImgUrl = gameNode["ImgUrl"].InnerText,
                    Name = gameNode["Name"].InnerText,
                    Objects = new List<GameObject>()
                };


                foreach (XmlNode gameObjNode in gameNode["Objects"].ChildNodes)
                {
                    newGame.Objects.Add(new GameObject()
                    {
                        ImgUrl = gameObjNode["ImgUrl"].InnerText,
                        Match = gameObjNode["Match"].InnerText,
                        Name = gameObjNode["Name"].InnerText,
                    });
                }
                _games.Add(newGame);
            }


        }

        public IEnumerable<Game> GetGames()
        {


            return _games;

        }
        public Game Get(int id)
        {
            Game g = _games.FirstOrDefault(gm => gm.ID == id);
            g.Objects = g.Objects.OrderBy(o => Guid.NewGuid()).ToList();
            return g;
        }
    }
}