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

namespace DevApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowsDataContext _dataContext { get; set; }
        private List<Langues> _lLanguesAvailable;
        public MainWindow()
        {
            DataContext = new MainWindowsDataContext();
            _dataContext = (MainWindowsDataContext)DataContext;
            
            //_dataContext.DeveloppementLangages();
            //DataContext = this;
            Load();
            InitializeComponent();
            Init();

        }
        private void Init()
        {
            listboxRight.ItemsSource = null;
            listboxRight.Items.Clear();
        }
        public void Load()
        {
            _dataContext.DeveloppementLangages();
            
            //_lLanguesAvailable = _dataContext.Languages;
        }
       

        public void MoveSelectedItemToRight(Object sender, RoutedEventArgs e)
        {
            /*
            listboxRight.Items.Add(listboxLeft.SelectedValue);
             //listboxRight.Items.Remove(listboxRight.SelectedValue);
             //listboxLeft.SelectedValue = null;
             _ = _dataContext.Languages.Remove(_dataContext.Languages.Find(
                 l => l.Nom == listboxLeft.SelectedValue.ToString()));

             listboxLeft.ItemsSource = null;
             listboxLeft.Items.Clear();
             listboxLeft.ItemsSource = _dataContext.Languages;
            
            
            
            // listboxLeft.SelectedValue = null;
            //listboxLeft.Items.Clear();
            */
            //listboxRight.ItemsSource = _dataContext.RightListLangues;
            var selectedItem = _dataContext.LeftListLangues.ElementAt(listboxLeft.SelectedIndex);
            _dataContext.LeftListLangues.Remove(selectedItem);
            
            //listboxLeft.ItemsSource = _dataContext.LeftListLangues.ToList();

            if (!_dataContext.RightListLangues.Contains(selectedItem))
            {
                listboxRight.ItemsSource = null;
                listboxRight.Items.Clear();
                listboxRight.Items.Add(selectedItem);
                _dataContext.RightListLangues.Add(selectedItem);
               
            }
            else
            {
                listboxRight.ItemsSource = _dataContext.RightListLangues;
            }
        }

        public void MoveSelectedItemToLeft(Object sender, RoutedEventArgs e)
        {

            //listboxLeft.ItemsSource = null;


            /* Langues langue = _lLanguesAvailable.Single
                 (l => l.Nom == listboxRight.SelectedValue.ToString());

             _dataContext.Languages.Add(langue);

             listboxLeft.Items.Add(listboxRight.SelectedValue.ToString());

             //listboxRight.Items.Remove(listboxRight.SelectedValue);
             //listboxLeft.SelectedValue = null;
             _ = _dataContext.Languages.Remove(_dataContext.Languages.Find(
                  l => l.Nom == listboxRight.SelectedValue.ToString()));

             listboxRight.ItemsSource = null;
             listboxRight.Items.Clear();
             listboxRight.ItemsSource = _dataContext.Languages;
            */
            /* if (listboxRight.SelectedItems.Count == 0)
             {
                 MessageBox.Show("Veuillez selectionez un élément");
             }
             else
             {

                 while (listboxRight.SelectedItems.Count > 0)
                 {
                     listboxLeft.Items.Add((listboxRight.SelectedItems[0]));
                     listboxRight.Items.Remove((listboxRight.SelectedItems[0]));
                 }
             }
            
           */
            
            listboxRight.Visibility = Visibility.Collapsed;
            listboxLeft.Visibility = Visibility.Collapsed;

            
            

            newListboxLeft.Items.Remove(listboxLeft.SelectedItem);
            //newListboxLeft.Items.RemoveAt(listboxLeft.SelectedIndex);
            newListboxLeft.Visibility = Visibility.Visible;
            newListboxRight.Items.Add(listboxLeft.SelectedValue);
            newListboxRight.Visibility = Visibility.Visible;

        }

        public void MoveAllItemToRight(Object sender, RoutedEventArgs routedEventArgs)
        {
            foreach (var el in _dataContext.Languages)
            {
               listboxRight.Items.Add(el.Nom);
               // listboxRight.Items.Add(el);
                // listboxLeft.Items.Clear();
            }

            listboxLeft.ItemsSource = null;
            listboxLeft.Items.Clear();

        }
        public void MoveAllItemToLeft(Object sender, RoutedEventArgs routedEventArgs)
        {
            foreach (var el in _dataContext.Languages)
            {
                listboxLeft.Items.Add(el.Nom);
                listboxRight.Items.Clear();
            }

            //listboxRight.ItemsSource = null;




        }
    }
}
