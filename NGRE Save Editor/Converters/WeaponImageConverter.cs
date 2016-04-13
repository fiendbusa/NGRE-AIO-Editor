using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using System.Windows;

namespace NGRE_Save_Editor
{
    class WeaponImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            BitmapImage wepImg = new BitmapImage();

            try
            {
                string source = value.ToString();
                wepImg = new BitmapImage(new Uri(source));
              
                
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return wepImg;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
