using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnGames.Web.Models
{
    public class Game
    {
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
        public List<GameObject> Objects { get; set; }
        public int ID { get; internal set; }
    }

    public class GameObject
    {
        public string ImgUrl { get; set; }
        public string Name { get; set; }
        public string Match { get; set; }
        public bool Correct { get; set; }
        public IEnumerable<string> Properties { get; set; }
    }
}