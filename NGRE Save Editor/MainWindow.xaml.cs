using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using NGRE_Save_Editor.Save_Files;
using NGRE_Save_Editor.Save_File;
using NGRE_Save_Editor.Codes;
using System.Linq;


namespace NGRE_Save_Editor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Set reference to mainwindow so other windows can access it.
        public Window MainWindowReference { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            MainWindowReference = this;
        }


        /*UI Logic 
         *Start
         */
        private void gridAyaneSide_MouseEnter(object sender, MouseEventArgs e)
        {
            
            border.BorderBrush = System.Windows.Media.Brushes.Purple;
            if (String.IsNullOrEmpty(SaveFile.SystemSave) && String.IsNullOrEmpty(SaveFile.ChapterSave)) return;
            var uriSource = new Uri(@"/Resources/Main_Mod_Other_Selection.png", UriKind.Relative);
            imgMainSelection.Source = new BitmapImage(uriSource);
        }

        private void gridRyuSide_MouseEnter(object sender, MouseEventArgs e)
        {
            
            border.BorderBrush = System.Windows.Media.Brushes.Red;
            if (String.IsNullOrEmpty(SaveFile.StorySave)) return;
            var uriSource = new Uri(@"/Resources/Main_Mod_Story_Selection.png", UriKind.Relative);
            imgMainSelection.Source = new BitmapImage(uriSource);
        }

        private void lblExit_MouseEnter(object sender, MouseEventArgs e)
        {
            Label exitLabel = (Label)sender;
            exitLabel.Foreground = System.Windows.Media.Brushes.Red;
        }

        private void lblExit_MouseLeave(object sender, MouseEventArgs e)
        {
            Label exitLabel = (Label)sender;
            exitLabel.Foreground = System.Windows.Media.Brushes.Black;
        }

        private void lblExit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            shutdownApplication();
        }
        private void shutdownApplication()
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Save Editor", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes) Application.Current.Shutdown();
        }

        private void lblMinimize_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Application.Current.MainWindow.WindowState = WindowState.Minimized;
            //SaveFile.writeHex(Save.System, OffsetCodes.unknownNinjaLevel, HexCodes.level98);
           
            //int[] myIntArray = Enumerable.Repeat(1234, 1000).ToArray();
        }

        private void lblSystemSave_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SaveFile.savePath(Save.System);
        }

        private void lblStorySave_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SaveFile.savePath(Save.Story);
            
        }

        private void lblChapSave_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SaveFile.savePath(Save.Chapter);
            
        }

        private void lblOtherMods_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //if (String.IsNullOrEmpty(SaveFile.SystemSave)) MessageBox.Show("System Save path not selected. Click System Save on the bottom right to point towards your save file.", "Save Error", MessageBoxButton.OK, MessageBoxImage.Error);  return;
            MiscModsMainWindow miscModsWindow = new MiscModsMainWindow();
            miscModsWindow.mainWindowRef = MainWindowReference;
            this.Hide();
            miscModsWindow.Show();
        }

        private void lblStoryMods_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(String.IsNullOrEmpty(SaveFile.StorySave)) MessageBox.Show("Story save path not selected. Click Story Save on the bottom right to point towards your save file.", "Save Error", MessageBoxButton.OK); return;
        }
        /*UI Logic
* Ends
*/
    }
}
        


 