using RimWorld;
using Verse;

namespace CooksCanRefuel
{
	public class WorkGiver_RefuelForCooks : WorkGiver_Refuel
	{
		public override bool HasJobOnThing(Pawn pawn, Thing t, bool forced = false)
		{
			return t.def.building.isMealSource && base.HasJobOnThing(pawn, t, forced);
		}
	}
}
