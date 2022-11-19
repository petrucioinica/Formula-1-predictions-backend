using Core.Data;
using Core.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Services
{
    public class TeamsService
    {
        public List<TeamClass> teams { get; set; }

        public TeamsService(Teams teams) {
            this.teams = teams.teams;
        }

        public List<TeamClass> getAllTeams()
        {
            return teams;
        }

        public TeamClass  getById(int id)
        {
            var team = teams.Find(t => t.Id == id);
            return team;
        }
    }
}
