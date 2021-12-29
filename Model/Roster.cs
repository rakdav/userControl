using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userControl.Model
{
    public class Roster
    {
        public string TeamName { get; private set; }
        private readonly List<Player> players = new List<Player>();
        public IEnumerable<Player> Players
        {
            get => new List<Player>(players);
        }

        public Roster(string teamName, 
            IEnumerable<Player> _players)
        {
            TeamName = teamName;
            this.players.AddRange(_players);
        }
    }
}
