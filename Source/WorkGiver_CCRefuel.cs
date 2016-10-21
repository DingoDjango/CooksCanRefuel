using Verse;
using RimWorld;

namespace CCRefuel
{
    public class WorkGiver_CCRefuel : WorkGiver_Refuel
    {
        public override ThingRequest PotentialWorkThingRequest
        {
            get
            {
                return ThingRequest.ForDef(ThingDef.Named("FueledStove"));
            }
        }
    }
}
