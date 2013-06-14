using NHibernate;
using NHibernate.Criterion;
using SuecaTournamentManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuecaTournamentManager.Utils
{
    class MatchMaker
    {
        public MatchMaker()
        {
        }

        public void RandomMatch(int tournamentId, IList<Team> teams) {
            ISession session = DatabaseManager.Instance.OpenSession();
            Tournament tournament = session.Load<Tournament>(tournamentId);
            Phase phase = new Phase();
            phase.Tournament = tournament;
            session.Save(phase);
            Random random = new Random();
            int number = 1;

            while (teams.Count > 0)
            {
                number = random.Next(0, teams.Count - 1);
                if (tournament.TournamentWithAssociations &&
                    teams[number].Association.Id != teams[0].Association.Id)
                {
                    Match match = new Match();
                    match.Tournament = tournament;
                    match.Phase = phase;
                    match.Team1 = teams[0];
                    match.Team2 = teams[number];
                    session.Save(match);
                    teams.Remove(match.Team1);
                    teams.Remove(match.Team2);
                    number = 1;
                }
                else if (!tournament.TournamentWithAssociations)
                {
                    Match match = new Match();
                    match.Tournament = tournament;
                    match.Phase = phase;
                    match.Team1 = teams[0];
                    match.Team2 = teams[number];
                    session.Save(match);
                    teams.Remove(match.Team1);
                    teams.Remove(match.Team2);
                }
                else
                {
                    number++;
                }
            }
            session.Flush();
            session.Close();
        }

        public void TournamentMatch(IList<Team> teams)
        {
            ISession session = DatabaseManager.Instance.OpenSession();
            Phase phase = new Phase();
            Phase lastPhase = session.CreateCriteria<Phase>()
               .List<Phase>().Last<Phase>();

            IList<Match> allMatches = session.CreateCriteria<Match>()
                /* TODO: Support multiple tournaments
                .Where(x => x.Tournament.Id == tournamentId)
                */
                .List<Match>();

            /*
                SELECT id, SUM(score), SUM(line)
                FROM Results
                WHERE tid = 0
                GROUP BY id;             
             */

            IList<Match> lastPhaseMatches = allMatches.Where(i => i.Phase.Id == lastPhase.Id).ToList();
            /*int pos = 1;
            while (teams.Count > 0)
            {
                if (teams[0].Association.Id != teams[number].Association.Id)
                {
                    Match match = new Match();
                    match.Phase = phase;
                    match.Teams.Add(teams[0]);
                    match.Teams.Add(teams[number]);
                    session.Save(match);
                    teams.RemoveAt(0);
                    teams.RemoveAt(number);
                }
            }*/
        }
    }
}
