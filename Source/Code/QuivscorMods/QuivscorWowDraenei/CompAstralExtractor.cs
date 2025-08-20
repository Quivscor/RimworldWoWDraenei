using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace QuivscorWowDraenei
{
    public class CompAstralExtractor : CompScanner
    {
        public new CompProperties_AstralExtractor Props
        {
            get
            {
                return this.props as CompProperties_AstralExtractor;
            }
        }

        protected override void DoFind(Pawn worker)
        {
            IncidentParms parms = new IncidentParms();
            parms.target = worker.Map;
            parms.bypassStorytellerSettings = true;
            parms.forced = true;
            meteorites.def = Props.spawnedIncident;
            meteorites.TryExecute(parms);
        }

        private IncidentWorker_MeteoriteImpact meteorites = new IncidentWorker_MeteoriteImpact();
    }
}
