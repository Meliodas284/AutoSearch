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

namespace AutoSearch
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
    }
}
