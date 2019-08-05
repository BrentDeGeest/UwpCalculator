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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GridButtons
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page2 : Page
    {
        public Page2()
        {
            this.InitializeComponent();
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button1.IsEnabled = false;
            AllButtonsClicked();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button2.IsEnabled = false;
            AllButtonsClicked();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Button3.IsEnabled = false;
            AllButtonsClicked();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Button4.IsEnabled = false;
            AllButtonsClicked();
        }

        private void AllButtonsClicked()
        {
            if (Button1.IsEnabled == false && Button2.IsEnabled == false && Button3.IsEnabled == false && Button4.IsEnabled == false)
            {
                Frame.Navigate(typeof(Page3));
            }
        }
    }
}
