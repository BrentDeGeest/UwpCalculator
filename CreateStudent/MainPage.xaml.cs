using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CreateStudent
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog Confirmation = new ContentDialog()
            {
                Title = "Are you sure?",
                CloseButtonText = "Close",
                PrimaryButtonText = "Yes",
                SecondaryButtonText = "No"
                
            };
            StudentSaved(Confirmation);
        }

        private async void StudentSaved(ContentDialog Confirmation)
        {
            ContentDialogResult result = await Confirmation.ShowAsync();
            if(result == ContentDialogResult.Primary)
            {
                Frame.Navigate(typeof(StudentSavedPage));
            }
            else if (result == ContentDialogResult.Secondary)
            {
                Frame.Navigate(typeof(StudentNotSavedPage));
            }
        }

        private void ChangeColor()
        {
            SaveButton.Background = (SolidColorBrush)Resources["Blue"];
        }
    }
}
