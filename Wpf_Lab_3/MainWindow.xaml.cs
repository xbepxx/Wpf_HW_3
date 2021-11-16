using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Lab_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (Vindou != null)
            {
                Vindou.FontFamily = new FontFamily(fontName);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string FontSize = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            double fontSize = double.Parse(FontSize);
            if (Vindou != null)
            {
                Vindou.FontSize = fontSize;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Vindou != null)
            {
                Vindou.FontWeight = FontWeights.Bold;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Vindou != null)
            {
                Vindou.FontStyle= FontStyles.Italic;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Vindou != null)
            {
                Vindou.TextDecorations = TextDecorations.Underline;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            //Foreground = "Red"
            if (Vindou != null)
            {
                Vindou.Foreground = Brushes.Black;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (Vindou != null)
            {
                Vindou.Foreground = Brushes.Red;
            }
        }
    }
}
