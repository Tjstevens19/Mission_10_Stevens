using BowlingFun.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BowlingFun.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlerController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }



        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            // Get all bowlers
            var bowlers = _bowlerRepository.Bowlers;
            foreach (var bowler in bowlers)
            {
                // Get the team for each bowler
                bowler.Team = _bowlerRepository.GetTeamById(bowler.TeamID);
            }

            return bowlers;
        }
    }
}
