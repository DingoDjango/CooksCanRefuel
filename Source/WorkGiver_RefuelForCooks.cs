using Verse;
using RimWorld;

namespace CooksCanRefuel
{
	public class WorkGiver_RefuelForCooks : WorkGiver_Refuel
	{
		public override bool HasJobOnThing(Pawn pawn, Thing t, bool forced = false)
		{
			return base.HasJobOnThing(pawn, t) && t.def.building.isMealSource;
		}
	}
}