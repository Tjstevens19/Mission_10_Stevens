namespace BowlingFun.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlerContext context;
        public EFBowlerRepository(BowlerContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Bowler> Bowlers => context.Bowlers;
        public IEnumerable<Team> Teams => context.Teams;

        public Team GetTeamById(int? teamID)
        {
            return context.Teams.Find(teamID);
        }
    }
}
