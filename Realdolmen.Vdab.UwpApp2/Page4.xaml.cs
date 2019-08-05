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

namespace Realdolmen.Vdab.UwpApp2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page4 : Page
    {
        int buttonContent;
        int score = 0;
        int clickPower = 1;
        public Page4()
        {
            this.InitializeComponent();
            Page4Button.IsChecked = true;
        }

        private void Page1Button_Checked(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));

        }
        private void Page2Button_Checked(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page2));

        }

        private void Page3Button_Checked(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page3));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            button.Width-=5;
            button.Height-=5;
            score += 1;
            ScoreText.Text = score.ToString();
            buttonContent = Convert.ToInt32(button.Content) - clickPower;
            if(buttonContent <= 0)
            {
                button.IsEnabled = false;
            }
            button.Content = buttonContent;
        }

        private void UpgradeClickButton_Click(object sender, RoutedEventArgs e)
        {
            if(score >= 3)
            {
                clickPower += 1;
                score -= 3;
            }

        }
    }
}
