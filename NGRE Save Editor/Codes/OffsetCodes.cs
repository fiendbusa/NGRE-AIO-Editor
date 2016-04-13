using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGRE_Save_Editor.Codes
{
    public static class OffsetCodes
    {
        //Unknown Ninja Skin Color
        public const long unknownNinjaSkinColor = 8316;
        //Outfits (including pre-order bonuses and unmasked Hayabusa)
        public static readonly long[] hayabusaCostumes =  { 27285, 27286, 27287, 27288, 27290, 24765 };
        public static readonly long[] ayaneCostumes = { 27317, 27318, 27319, 27320 };
        public static readonly long[] momijiCostumes = { 27333, 27334, 27335, 27336 };
        public static readonly long[] kasumiCostumes = {27349, 27350, 27351, 27352 };
        /*Menu Unlocks*/
        public static readonly long[] menus = { 27256, 27257, 27258, 27259, 27260, 27261, 27263, 27264, 27265, 27266, 27267, 27268, 27269, 27270, 27271, 27277 };
        //Unknown Ninja Level
        public static readonly long[] unknownNinjaLevel = { 8240, 8241, 8242, 8243 };
        //Online Karma
        public static readonly long[] onlineKarma = { 9298, 9299, 9300, 9301, 9302, 9303 };
        //Online Weapon Level
        public static readonly Dictionary<string, long[]> weaponLevels = new Dictionary<string, long[]>
        {
            ["claws"] = new long[] {8252, 8253, 8254, 8255 },
            ["bota"] = new long[] {8268, 8269, 8270, 8271},
            ["kg"] = new long[] { 8284, 8285, 8286, 8287 },
            ["ds"] = new long[] { 8245, 8246, 8247, 8248 },
            ["scythe"] = new long[] { 8260, 8261, 8262, 8263, 8264 },
            ["lunar"] = new long[] { 8276, 8277, 8278, 8279, 8280 },

        };
        //Online Ninpo Level
        public static readonly Dictionary<string, long[]> ninpoMaxlvl = new Dictionary<string, long[]>
        {
            ["void"] = new long[] { 8300, 8301, 8302, 8303 },
               
        };

       
        


    }
}
