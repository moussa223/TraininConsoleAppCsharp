using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace ExoDeplacerElementsEntreDeuxListeBoxWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowDataContext _dataContext { get; set; }
        public MainWindow()
        {
             DataContext = new MainWindowDataContext();
            _dataContext = (MainWindowDataContext) DataContext;

            _dataContext.DeveloppementLangages();
            //DataContext = this;

            InitializeComponent();

        }

        public void MoveSelectedItemToRight(Object sender, RoutedEventArgs e)
        {
            if (listboxLeft != null)
            {
                listboxRight.Items.Add(listboxLeft.SelectedValue.ToString());
                _dataContext.Languages.RemoveAt(listboxLeft.SelectedIndex);

            }
        }
        
        public void MoveAllItemToRight(Object sender, RoutedEventArgs routedEventArgs)
        {
            foreach (var el in _dataContext.Languages)
            {
                listboxRight.Items.Add(el);
               // listboxLeft.Items.Clear();
            }
            
                listboxLeft.ItemsSource = null;
                listboxLeft.Items.Clear();

        }
        public void MoveSelectedItemToLeft(Object sender, RoutedEventArgs e)
        {
            if (listboxRight != null)
            {
                listboxLeft.Items.Add(listboxRight.SelectedValue.ToString());
                _dataContext.Languages.RemoveAt(listboxRight.SelectedIndex);

            }
        }
        public void MoveAllItemToLeft(Object sender, RoutedEventArgs routedEventArgs)
        {
            foreach (var el in _dataContext.Languages)
            {
                listboxLeft.Items.Add(el);
                listboxRight.Items.Clear();
            }
           
                //listboxRight.ItemsSource = null;
            

            

        }
    }
}
