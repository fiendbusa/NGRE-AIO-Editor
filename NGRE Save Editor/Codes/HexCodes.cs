using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGRE_Save_Editor
{
    public static class HexCodes
    {
        /*Start
         *Secret Skin Colors for the unknown ninja*/
        public const byte unknownNinjaSkinColorGold = 0xff;
        public const byte unknownNinjaSkinColorBlack = 0x04;
        public const byte unknownNinjaSkinColorRed = 0x05;
        public const byte unknownNinjaSkinColorBlue = 0x06;
        public const byte unknownNinjaSkinColorTan = 0x07;
        public const byte unknownNinjaSkinColorGreen = 0x08;
        public const byte unknownNinjaSkinColorOrange = 0x09;
        /*End*/

        //Sets expereince 1 off to 99
        public static readonly byte[] level98 = { 0x06, 0xC5, 0x17, 0xDF };
        //Online karma
        public static readonly byte[] onlineKarmaMax = { 0x00, 0x03, 0x0F, 0xA7, 0x79, 0xD3 };

        //Online weapon max level
        public static readonly Dictionary<string, byte[]> wepMaxlvl = new Dictionary<string, byte[]>
        {
            ["claws"] = new byte[] { 0x01, 0x6B, 0x48, 0x20 },
            ["bota"] = new byte[] { 0x01, 0x54, 0x89, 0x0E },
            ["kg"] = new byte[] { 0x03, 0xDC, 0xC0, 0x4C },
            ["ds"] = new byte[] { 0xC5, 0x0B, 0x71, 0x12 },
            ["scythe"] = new byte[] { 0x03, 0x02, 0x25, 0xe7, 0x12 },
            ["lunar"] = new byte[] { 0x02, 0x5C, 0x8F, 0x8E, 0x12 },

        };
        //Online ninpo max level
        public static readonly Dictionary<string, byte[]> ninpoMaxlvl = new Dictionary<string, byte[]>
        {
            ["void"] = new byte[] { 0x08, 0x7A, 0xF3, 0x3B }


        };
    }
}




