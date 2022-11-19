using Core.Services;
using Core.Test;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/teams")]
    public class TeamsController : Controller
    {
        public TeamsService teamsService { get; set; }

        public TeamsController(TeamsService teamsService)
        {
            this.teamsService = teamsService;
        }

        [HttpGet("all-teams")]
        public IActionResult AllTeams()
        {
            var allTeams = teamsService.getAllTeams();
            return Ok(allTeams);
        }
        
        [HttpGet("{id:int}")]
        public IActionResult TeamById(int id)
        {
            var team  = teamsService.getById(id);
            return Ok(team);
        }

        [HttpPost("create")]
        public IActionResult CreateTeam(TeamClass newTeam)
        {
            return Ok();
        }

    }

}