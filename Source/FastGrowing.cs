using ICities;
using UnityEngine;

namespace FastGrowingMod
{

    public class FastGrowing : IUserMod
    {
        public string Name 
        {
            get { return "Fast Growing"; }
        }

        public string Description 
        {
            get { return "Everybody wants to live in your city, EVERYBODY!"; }
        }
    }

    public class DemandModifier : DemandExtensionBase
    {

        public override int OnUpdateDemand(int lastDemand, int nextDemand, int targetDemand)
        {
            // Yeah, no smooth at all! That's how we are!
            return 100;
        }
    }

}
