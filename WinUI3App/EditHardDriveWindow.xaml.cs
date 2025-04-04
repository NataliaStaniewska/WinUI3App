using CommunityToolkit.WinUI.UI.Controls;
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
  
    public sealed partial class EditHardDriveWindow : Window
    {
        // Private field to store the reference to the collection of hard drives
        private ObservableCollection<HardDrive> _hardDrives;
        // Private field to store the object to be edited
        private HardDrive _hardDrive;
        public EditHardDriveWindow(ObservableCollection<HardDrive> hardDrives, HardDrive hardDrive)
        {
            this.InitializeComponent();
            _hardDrives = hardDrives; // Store the reference to the collection
            _hardDrive = hardDrive; // Store the reference to the object

            // Set up texts in the form fields with the objects data
            textBoxModel.Text = _hardDrive.Model;
            textBoxManufacturer.Text = _hardDrive.Manufacturer;
            comboBoxType.Text = _hardDrive.Type;
            numberBoxCapacity.Value = _hardDrive.Capacity;
        }

        // Save button functionality
        private void SaveButtonClick(object sender, RoutedEventArgs e)
        {
            // Assign new values to the object
            _hardDrive.Model = textBoxModel.Text;
            _hardDrive.Manufacturer = textBoxManufacturer.Text;
            if (comboBoxType.SelectedItem is ComboBoxItem selectedItem)
            {
                _hardDrive.Type = selectedItem.Content.ToString();
            }
            _hardDrive.Capacity = numberBoxCapacity.Value;



            this.Close(); // Close the window after saving




        }

        // Exit button functionality
        private void ExitButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
