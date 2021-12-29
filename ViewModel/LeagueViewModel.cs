using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userControl.Model;

namespace userControl.ViewModel
{
    public class LeagueViewModel
    {
        public RosterViewModel ChicagoBulls { get; set; }
        public RosterViewModel PhoenixSuns { get; set; }

        public LeagueViewModel()
        {
            var first = new Roster("Chicago Bulls", GetFirstRoster());
            ChicagoBulls = new RosterViewModel(first);
            var second = new Roster("Phenix Suns", GetSecondRoster());
            PhoenixSuns = new RosterViewModel(second);
        }

        private IEnumerable<Player> GetFirstRoster()
        {
            return new List<Player>()
            { new Player("Bobs",31,true),
              new Player("Vobs",29,true),
              new Player("Super",23,true),
              new Player("Tom",2,true),
              new Player("Jerry",3,true),
              new Player("Bags",38,false),
              new Player("Duck",77,false),
            };
        }

        private IEnumerable<Player> GetSecondRoster()
        {
            return new List<Player>()
            { new Player("Gobs",34,true),
              new Player("Mobs",23,true),
              new Player("Kuper",26,true),
              new Player("Yom",20,true),
              new Player("Herry",34,true),
              new Player("Lags",39,false),
              new Player("Wuck",73,false),
            };
        }
    }
    

}
