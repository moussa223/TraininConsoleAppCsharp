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

namespace ExoJeuDeCouleursFormulaire4
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
        public void SetSelectedColor(Object sender,RoutedEventArgs e)
        {
            if (lbiRouge.IsSelected)
            {
                lbiRouge.Background = new SolidColorBrush(Colors.Red);
            }
            else if (lbiVert.IsSelected)
            {
                lbiVert.Background = new SolidColorBrush(Colors.Green);
            }
            else if (lbiBleu.IsSelected)
            {
                lbiBleu.Background = new SolidColorBrush(Colors.Blue);
            }
            else if (lbiJaune.IsSelected)
            {
                lbiJaune.Background = new SolidColorBrush(Colors.Yellow);
            }
        }
        public void UnsetSelectedColor(Object sender,RoutedEventArgs e)
        {
            if (lbiRouge.IsSelected)
            {
                lbiRouge.Background = new SolidColorBrush(Colors.LightGray);
            }
            else if (lbiVert.IsSelected)
            {
                lbiVert.Background = new SolidColorBrush(Colors.LightGray);
            }
            else if (lbiBleu.IsSelected)
            {
                lbiBleu.Background = new SolidColorBrush(Colors.LightGray);
            }
            else if (lbiJaune.IsSelected)
            {
                lbiJaune.Background = new SolidColorBrush(Colors.LightGray);
            }
        }
    }
}
