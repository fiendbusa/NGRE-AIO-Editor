using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NGRE_Save_Editor.Save_Files;
using NGRE_Save_Editor.Save_File;

namespace NGRE_Save_Editor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        /*UI Logic 
         *Start
         */
        private void gridAyaneSide_MouseEnter(object sender, MouseEventArgs e)
        {
            if (String.IsNullOrEmpty(SaveFile.ChapterSave) && String.IsNullOrEmpty(SaveFile.StorySave)) return;
            var uriSource = new Uri(@"/Resources/Main_Mod_Other_Selection.png", UriKind.Relative);
            imgMainSelection.Source = new BitmapImage(uriSource);
        }

        private void gridRyuSide_MouseEnter(object sender, MouseEventArgs e)
        {
            if (String.IsNullOrEmpty(SaveFile.SystemSave)) return;
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
            SaveFile.savePath(Save.System);
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void lblSystemSave_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SaveFile.savePath(Save.System);
        }

        private void lblStorySave_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SaveFile.savePath(Save.Story);
            SaveFile.writeHex(Save.Story, new long[] {0x0,0x1,0x2,0x3 }, new byte[] { 0xA4, 0xA4});
        }

        private void lblChapSave_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SaveFile.savePath(Save.Chapter);
            
        }
        /*UI Logic
        * Ends
        */
    }
}
        


 