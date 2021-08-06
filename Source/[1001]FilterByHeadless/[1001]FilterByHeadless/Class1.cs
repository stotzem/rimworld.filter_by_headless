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
    public class FilterByHeadlessMod : Mod
    {
        public FilterByHeadlessMod(ModContentPack content) : base(content) { }
    }

    public class SpecialThingFilterWorker_FilterByHeaded : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t) => CanEverMatch(t.def) && t.TryGetComp<>();
        public override bool CanEverMatch(ThingDef def) => def.HasComp(typeof())
    }

    public class SpecialThingFilterWorker_FilterByHeadless : SpecialThingFilterWorker
    {

    }
}
