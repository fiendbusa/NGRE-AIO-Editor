using System.Windows;
using NGRE_Save_Editor.MiscMods;
using NGRE_Save_Editor.Save_File;
using NGRE_Save_Editor.Save_Files;
using System.Linq;


namespace NGRE_Save_Editor
{
    /// <summary>
    /// Interaction logic for MiscModsMainWindow.xaml
    /// </summary>
    public partial class MiscModsMainWindow : Window
    {
        //Holds a reference to the main window.
        public Window mainWindowRef { get; set; }

        Weapons weapons;
        public MiscModsMainWindow()
        {
            InitializeComponent();
            weapons = new Weapons();
            this.DataContext = weapons; 
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            radioLvl1.IsChecked = true;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            weapons.nextWeapon();
            weapons.setWeaponImg();
            weapons.setOffsetAndHex();

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainWindowRef.Show();
            
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            if(weapons.WeaponOffset.Length < 0 && weapons.WeaponHex.Length < 0)throw new System.ArgumentException("Weapon Offset or Weapon Hex value is invalid");
            var hexCount = weapons.WeaponHex.Length;
            if (radioLvl1.IsChecked == true)
            {
                SaveFile.writeHex(Save.System, weapons.WeaponOffset, new byte[hexCount]);
            }
            else
            {

                SaveFile.writeHex(Save.System, weapons.WeaponOffset, weapons.WeaponHex);
            }
        }
    }
}
