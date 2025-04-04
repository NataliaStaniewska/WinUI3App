using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;



namespace WinUI3App
{
    public sealed partial class AddHardDriveWindow : Window
    {
        // Private field to store the reference to the collection of hard drives
        private ObservableCollection<HardDrive> _hardDrives;

        // Constructor that receives the existing collection of hard drives from the main window
        public AddHardDriveWindow(ObservableCollection<HardDrive> hardDrives)
        {
            this.InitializeComponent();
            _hardDrives = hardDrives; // Store the reference to the collection


        }

        // Save button functionality
        private void SaveButtonClick(object sender, RoutedEventArgs e)
        {
            string model = textBoxModel.Text;
            string manufacturer = textBoxManufacturer.Text;
            string type = comboBoxType.SelectedValue as string;
            double capacity = numberBoxCapacity.Value;

            HardDrive newHardDrive = new HardDrive(model, manufacturer, type, capacity);
            _hardDrives.Add(newHardDrive); // Add new record to the collection
            this.Close(); // Close the window after saving

        }

        // Exit button functionality
        private void ExitButtonClick(object sender, RoutedEventArgs e)
        {
           this.Close();

        }
    }
}
