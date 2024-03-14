namespace BowlingFun.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }
        
        Team GetTeamById(int? teamID);

    }
}
