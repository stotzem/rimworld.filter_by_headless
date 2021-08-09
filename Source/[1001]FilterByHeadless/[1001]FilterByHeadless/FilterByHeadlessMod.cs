using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RimWorld;

using UnityEngine;
using Verse;

namespace _1001_FilterByHeadless
{
    public class SpecialThingFilterWorker_FilterByHeaded : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t)
        {
            Corpse corpse = t as Corpse;
            if(corpse != null && corpse.InnerPawn.health.hediffSet.GetNotMissingParts(BodyPartHeight.Undefined, BodyPartDepth.Undefined, null, null).Any((BodyPartRecord p) => p.def == BodyPartDefOf.Head))
            {
                return true;
            }
            return false;
        }
    }

    public class SpecialThingFilterWorker_FilterByHeadless : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t)
        {
            Corpse corpse = t as Corpse;
            if (corpse != null && corpse.InnerPawn.health.hediffSet.GetNotMissingParts(BodyPartHeight.Undefined, BodyPartDepth.Undefined, null, null).Any((BodyPartRecord p) => p.def == BodyPartDefOf.Head))
            {
                return false;
            }
            return true;
        }
    }
}
