using RimWorld;
using UnityEngine;
using Verse;

namespace RoofBuild_Mod
{
    public class Designator_AreaBuildRoofMod : Designator_AreaBuildRoof
    {
        private DesignateMode mode;

        public Designator_AreaBuildRoofMod()
        {
            mode = DesignateMode.Add;
            defaultLabel = "BRBT_Label".Translate();
            defaultDesc = "BRBT_Description".Translate();
            icon = ContentFinder<Texture2D>.Get("UI/Designators/BuildRoofArea");
        }

        public override AcceptanceReport CanDesignateCell(IntVec3 c)
        {
            return c.InBounds(Map) &&
                   !c.Fogged(Map) &&
                   RoofCollapseUtility.WithinRangeOfRoofHolder(c, Map, true);
        }
    }
}