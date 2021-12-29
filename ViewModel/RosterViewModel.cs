using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userControl.Model;

namespace userControl.ViewModel
{
    public class RosterViewModel
    {
        public ObservableCollection<PlayerViewModel> Starters { get; set; }
        public ObservableCollection<PlayerViewModel> Bench { get; set; }
        
        private Roster roster;
        
        private string teamName;
        public string TeamName 
        {
            get { return teamName; }
            set { teamName = value; }
        }

        public RosterViewModel(Roster roster)
        {
            this.roster = roster;
            Starters = new ObservableCollection<PlayerViewModel>();
            Bench = new ObservableCollection<PlayerViewModel>();
            TeamName = roster.TeamName;
            UpdateRoster();
        }
        public void UpdateRoster()
        {
            var startingPlayers = roster.Players.Where(player => player.Starter).
                Select(player => new PlayerViewModel(player.Name,player.Number));
            foreach(var playerViewmodel in startingPlayers)
            {
                Starters.Add(playerViewmodel);
            }

            var banchPlayers = roster.Players.Where(player => !player.Starter).
                Select(player => new PlayerViewModel(player.Name, player.Number));
            foreach (var playerViewmodel in banchPlayers)
            {
                Bench.Add(playerViewmodel);
            }
        }
    }
}
