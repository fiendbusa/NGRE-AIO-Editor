using System;
using System.Linq;
using System.Windows.Media.Imaging;
using NGRE_Save_Editor.Codes;

namespace NGRE_Save_Editor.MiscMods
{
    partial class Weapons
    {

        public byte[] WeaponHex { get; private set; }
        public long[] WeaponOffset { get; private set; }
        public BitmapImage WeaponImg { get; set; }


        Uri clawImgPath = new Uri("pack://application:,,,/Images/img_CLAWS.png");
        Uri botaImgPath = new Uri("pack://application:,,,/Images/img_BOTA.png");
        Uri dsImgPath = new Uri("pack://application:,,,/Images/img_DS.png");
        Uri kgImgPath = new Uri("pack://application:,,,/Images/img_KG.png");
        Uri lunarImgPath = new Uri("pack://application:,,,/Images/img_LUNAR.png");
        Uri scytheImgPath = new Uri("pack://application:,,,/Images/img_SCYTHE.png");

        public Weapons()
        {
            CurrentWepSelected = HexCodes.wepMaxlvl.First().Key;
            WeaponOffset = OffsetCodes.weaponLevels.First().Value;
            setWeaponImg();
            setOffsetAndHex();
        }

        //Sets the appropriate weapon image according to the weapon selected 
        public void setWeaponImg()
        {

            switch (CurrentWepSelected)
            {
                case "claws":
                    WeaponImg = new BitmapImage(clawImgPath);
                    break;
                case "bota":
                    WeaponImg = new BitmapImage(botaImgPath);
                    break;
                case "ds":
                    WeaponImg = new BitmapImage(dsImgPath);
                    break;
                case "kg":
                    WeaponImg = new BitmapImage(kgImgPath);
                    break;
                case "lunar":
                    WeaponImg = new BitmapImage(lunarImgPath);
                    break;
                case "scythe":
                    WeaponImg = new BitmapImage(scytheImgPath);
                    break;
                default:
                    WeaponImg = new BitmapImage(clawImgPath);
                    break;

            }
            ImgSource = WeaponImg.UriSource;
        }
        
        //Get Next Weapon
        public void nextWeapon()
        {
            //Check to prevent going over the last value in the dictionary
            //if (HexCodes.wepMaxlvl.Max().Key.Contains(CurrentWepSelected)) { CurrentWepSelected = HexCodes.wepMaxlvl.Min().Key; return; }

            switch (CurrentWepSelected)
            {
                case "claws":
                    CurrentWepSelected = "bota";
                    break;
                case "bota":
                    CurrentWepSelected = "ds";
                    break;
                case "ds":
                    CurrentWepSelected = "kg";
                    break;
                case "kg":
                    CurrentWepSelected = "lunar";
                    break;
                case "lunar":
                    CurrentWepSelected = "scythe";
                    break;
                default:
                    CurrentWepSelected = "claws";
                    break;

            }
        }
        public void setOffsetAndHex()
        {
            //TODO: Remove on release
            TestHex = "";
            TestHex = "Hex(Decimal) ";
            TestOffset = "";
            TestOffset = "Offset(Decimal) ";

            WeaponHex = (from h in HexCodes.wepMaxlvl
                         where h.Key.Contains(CurrentWepSelected)
                         select h.Value).SelectMany(i => i).ToArray();

            WeaponOffset = (from o in OffsetCodes.weaponLevels
                            where o.Key.Contains(CurrentWepSelected)
                            select o.Value).SelectMany(i => i).ToArray();
                            
            
            //TODO: Remove on release
            for(int i = 0; i < WeaponHex.Length; i++)
            {
                TestHex += WeaponHex[i].ToString() + " ";
            }
            for (int i = 0; i < WeaponOffset.Length; i++)
            {
                TestOffset += WeaponOffset[i].ToString() + " ";
            }
        }
    }
}



   
           

