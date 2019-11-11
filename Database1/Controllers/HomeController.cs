using Database1.DAL;
using Database1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Database1.Controllers
{
    public class HomeController : Controller
    {
        private BasketballContext db = new BasketballContext();

        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<NewPlayer> player = db.Database.SqlQuery<NewPlayer>(
                "Select Team.teamID, Team.teamName, Player.playerID, " +
                "Player.playerLastName, Player.playerFirstName, " +
                "Position.positionCode,  Position.positionDesc " +
                "FROM Team, Player, Position " +
                "WHERE Team.teamID = Player.teamID AND " +
                "Player.positionCode = Position.positionCode " +
                "Order by Team.teamName, Player.playerLastName, " +
                "Player.playerFirstName");

            return View(player);
        }
    }
}