using Labo_7___Polymorphism.Data;
using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Labo_7___Polymorphism.Entities;

namespace Labo_7___Polymorphism;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private Store<Machine> _store { get; set; } = new Store<Machine>();
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ImportButton_Click(object sender, RoutedEventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
            Title = "Select a CSV file"
        };

        if (openFileDialog.ShowDialog() == true)
        {
            _store.AddRange(FileHandler.ImportFile(openFileDialog.FileName));
            itemsListBox.ItemsSource = _store.GetAllItems();
        }
    }

    private void RemoveButton_Click(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void ClearButton_Click(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void UseButton_Click(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void SortButton_Click(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void FilterButton_Click(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void itemsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        throw new NotImplementedException();
    }
}