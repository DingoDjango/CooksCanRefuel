using Verse;
using RimWorld;

namespace CooksCanRefuel
{
	public class WorkGiver_RefuelForCooks : WorkGiver_Refuel
	{
		public override bool HasJobOnThing(Pawn pawn, Thing t)
		{
			return base.HasJobOnThing(pawn, t) && t.def.building.isMealSource;
		}

		public override bool HasJobOnThingForced(Pawn pawn, Thing t)
		{
			return base.HasJobOnThingForced(pawn, t) && t.def.building.isMealSource;
		}
	}
}