using Core.Test;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public class Teams
    {
        public List<TeamClass> teams { get; set; }

        public Teams() {
            var id = 0;
            var teams = new List<TeamClass>();

            var Ferrari = new TeamClass();
            Ferrari.Points = 524;
            Ferrari.MainColor = "Red";
            Ferrari.Name = "Ferrari";
            Ferrari.Description = "The Ferrari works team";
            Ferrari.Engine = Engine.Ferrari;
            Ferrari.Id  = id;
            id++;
            teams.Add(Ferrari);

            var RedBull = new TeamClass();
            RedBull.Points = 719;
            RedBull.MainColor = "Navy Blue";
            RedBull.Name = "Oracle Red Bull Racing";
            RedBull.Description = "The Red Bull team";
            RedBull.Engine = Engine.RBPT;
            RedBull.Id  = id;
            id++;
            teams.Add(RedBull);

            var Mercedes = new TeamClass();
            Mercedes.Points = 505;
            Mercedes.MainColor = "Silver";
            Mercedes.Name = "Mercedes AMG Petronas";
            Mercedes.Description = "The Mercedes works team";
            Mercedes.Engine = Engine.Mercedes;
            Mercedes.Id  = id;
            id++;
            teams.Add(Mercedes);

            this.teams = teams;

        }

    }
}
