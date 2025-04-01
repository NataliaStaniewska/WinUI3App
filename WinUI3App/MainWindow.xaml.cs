using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3App
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        ObservableCollection<HardDrive> hardDrives = new ObservableCollection<HardDrive> ();
        public MainWindow()
        {
            this.InitializeComponent();

            hardDrives.Add(new HardDrive("XYZ", "samsung", "HDD", 500));
            hardDrives.Add(new HardDrive("XYZ", "samsung", "HDD", 500));
            hardDrives.Add(new HardDrive("XYZ", "samsung", "HDD", 500));
            hardDrives.Add(new HardDrive("XYZ", "samsung", "HDD", 500));


            myDataGrid.ItemsSource = hardDrives;
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Add Button clicked");
        }

        private void EditButtonClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Edit Button clicked");
        }

        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            if(myDataGrid.SelectedItem is HardDrive selectedDrive)
            {
                hardDrives.Remove(selectedDrive);
            }
            
        }
    }
}
