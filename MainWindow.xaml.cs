using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace AutoSearch
{
    public partial class MainWindow : Window
    {
        ObservableCollection<Auto> autoCollection;
        SearchParams autoParam = new SearchParams()
        {
            Mark = "%",
            BodyType = "%",
            GearType = "%",
            EngineType = "%",
            Transmission = "%",
            Wheel = "%",
            PriceFrom = 0,
            PriceTo = 1000000000,
            PowerFrom = 0,
            PowerTo = 1000
        };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = autoParam;

            markComboBox.ItemsSource = Categories.marks;
            markComboBox.DisplayMemberPath = "Value";
            markComboBox.SelectedValuePath = "Key";
            
            categoryComboBox.ItemsSource = Categories.bodyType;
            categoryComboBox.DisplayMemberPath = "Value";
            categoryComboBox.SelectedValuePath = "Key";
            
            gearComboBox.ItemsSource = Categories.gearType;
            gearComboBox.DisplayMemberPath = "Value";
            gearComboBox.SelectedValuePath = "Key";
            
            engineComboBox.ItemsSource = Categories.engineType;
            engineComboBox.DisplayMemberPath = "Value";
            engineComboBox.SelectedValuePath = "Key";
            
            transmissionComboBox.ItemsSource = Categories.transmission;
            transmissionComboBox.DisplayMemberPath = "Value";
            transmissionComboBox.SelectedValuePath = "Key";
            
            wheelComboBox.ItemsSource = Categories.wheel;
            wheelComboBox.DisplayMemberPath = "Value";
            wheelComboBox.SelectedValuePath = "Key";
        }

        private void sndButton_Click(object sender, RoutedEventArgs e)
        {
            string query = Query.createQuery(autoParam);
            autoCollection = Query.executeQuery(query);
            if (autoCollection == null)
            {
                MessageBox.Show("Результатов по вашему запросу не найдено.");
            }
            else
            {
                Result resultWindow = new Result();
                resultWindow.resList.ItemsSource = autoCollection;
                resultWindow.Show();
            }
        }

        private void textInput_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            long val;
            if (!long.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        private void keyInput_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }
    }
}
