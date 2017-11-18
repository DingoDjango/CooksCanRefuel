using System.Collections.Generic;
using RimWorld;
using Verse;

namespace Cooks_Can_Refuel
{
	public class WorkGiver_RefuelForCooks : WorkGiver_Refuel
	{
		//RimWorld.JobGiver_Work.TryIssueJobPackage
		public override IEnumerable<Thing> PotentialWorkThingsGlobal(Pawn pawn)
		{
			return pawn.Map.listerThings.ThingsMatching(this.PotentialWorkThingRequest).FindAll(t => t.def.building.isMealSource);
		}
	}
}
