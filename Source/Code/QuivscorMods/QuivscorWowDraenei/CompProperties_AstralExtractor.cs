using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace QuivscorWowDraenei
{
    public class CompProperties_AstralExtractor : CompProperties_Scanner
    {
        public IncidentDef spawnedIncident;

        public CompProperties_AstralExtractor()
        {
            this.compClass = typeof(CompAstralExtractor);
        }
    }
}
