using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseHangmanForms.Logic
{
    public class TeamCollection
    {
        // Fields
        List<Team> _teamList = new List<Team>();

        // Methods
        public void AddTeam(Team team)
        {
            _teamList.Add(team);
        }

        public List<Team> GetTeamList()
        {
            return _teamList;
        }
    }
}
