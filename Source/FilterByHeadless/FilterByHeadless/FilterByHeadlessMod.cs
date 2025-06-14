using System.Linq;
using RimWorld;
using Verse;

namespace FilterByHeadless
{
    public class SpecialThingFilterWorkerFilterByHeaded : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t)
        {
            var corpse = t as Corpse;
            return corpse != null && corpse.InnerPawn.health.hediffSet.GetNotMissingParts()
                .Any(p => p.def == BodyPartDefOf.Head);
        }
    }

    public class SpecialThingFilterWorkerFilterByHeadless : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t)
        {
            var corpse = t as Corpse;
            return corpse == null || corpse.InnerPawn.health.hediffSet.GetNotMissingParts()
                .All(p => p.def != BodyPartDefOf.Head);
        }
    }
}