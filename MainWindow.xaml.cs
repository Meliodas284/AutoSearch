using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace AutoSearch
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Auto> autoCollection;
        public MainWindow()
        {
            InitializeComponent();

            markComboBox.ItemsSource = Categories.marks;
            markComboBox.DisplayMemberPath = "Key";
            markComboBox.SelectedValuePath = "Value";
            
            categoryComboBox.ItemsSource = Categories.bodyType;
            categoryComboBox.DisplayMemberPath = "Key";
            categoryComboBox.SelectedValuePath = "Value";
            
            gearComboBox.ItemsSource = Categories.gearType;
            gearComboBox.DisplayMemberPath = "Key";
            gearComboBox.SelectedValuePath = "Value";
            
            engineComboBox.ItemsSource = Categories.engineType;
            engineComboBox.DisplayMemberPath = "Key";
            engineComboBox.SelectedValuePath = "Value";
            
            transmissionComboBox.ItemsSource = Categories.transmission;
            transmissionComboBox.DisplayMemberPath = "Key";
            transmissionComboBox.SelectedValuePath = "Value";
            
            wheelComboBox.ItemsSource = Categories.wheel;
            wheelComboBox.DisplayMemberPath = "Key";
            wheelComboBox.SelectedValuePath = "Value";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            SearchParams param = (SearchParams)this.Resources["params"];
            string query = Query.createQuery(param);
            autoCollection = Query.executeQuery(query);
            MessageBox.Show(autoCollection[0].ToString());
        }
    }

    public class SearchParams
    {
        public string Mark { get; set; }
        public string BodyType { get; set; }
        public string GearType { get; set; }
        public string EngineType { get; set; }
        public string Transmission { get; set; }
        public string Wheel { get; set; }
        public ulong PriceFrom { get; set; }
        public ulong PriceTo { get; set; }
        public uint PowerFrom { get; set; }
        public uint PowerTo { get; set; }

        public override string ToString()
        {
            string text = $"{PriceFrom}\n{PriceTo}\n{PowerFrom}\n{PowerTo}";
            return text;
        }
    }
}
