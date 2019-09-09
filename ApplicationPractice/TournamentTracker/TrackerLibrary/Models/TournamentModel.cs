using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        public List<Prize2Model> Prizes { get; set; } = new List<Prize2Model>();
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
