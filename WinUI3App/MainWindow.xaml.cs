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

namespace WinUI3App
{
    public sealed partial class MainWindow : Window
    {
        // Collection of displayed objects
        public ObservableCollection<HardDrive> hardDrives = new ObservableCollection<HardDrive> ();
        public MainWindow()
        {
            this.InitializeComponent();

            // Add objects to the collection
            hardDrives.Add(new HardDrive("XYZ", "samsung1", "HDD", 500));
            hardDrives.Add(new HardDrive("XYZ", "samsung2", "HDD", 500));
            hardDrives.Add(new HardDrive("XYZ", "samsung3", "HDD", 500));
            hardDrives.Add(new HardDrive("XYZ", "samsung4", "HDD", 500));

            // Link items from the collection to datagrid in UI
            myDataGrid.ItemsSource = hardDrives;
        }

        // Add buttton functionality
        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            var addHardDriveWindow = new AddHardDriveWindow(hardDrives); // Pass the collection to the new window
            addHardDriveWindow.Activate(); // Display the new window

        }

        // Edit button functionality
        private void EditButtonClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Edit Button clicked");
        }

        // Delete buttton functionality
        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            // Check if an item is selected in datagrid
            if(myDataGrid.SelectedItem is HardDrive selectedDrive)
            {
                // Remove the selected HardDrive from the list
                hardDrives.Remove(selectedDrive);
            }
            
        }
    }
}
