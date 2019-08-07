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

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int teller;

        

        public MainPage()
        {
            this.InitializeComponent();
            

        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {

            NewButtonLeft();
            NewButtonRight();
            NewButtonUp();
            NewButtonDown();
            PlayArea.Children.Remove(StartButton);
            teller += 100;
        }
        private void NewButtonLeft()
        {
            Thickness margin = StartButton.Margin;
            margin.Left = 400-teller;
            margin.Right = 0;
            margin.Top = 0;
            margin.Bottom = 0;
            Button newButton = new Button()
            {
                Margin = margin,
                Content = "A button",
                
                
            };
            newButton.Click += StartButton_Click;
            PlayArea.Children.Remove(newButton);
            PlayArea.Children.Add(newButton);
        }
        private void NewButtonRight()
        {
            Thickness margin = StartButton.Margin;
            margin.Left = 800+teller;
            margin.Right = 0;
            margin.Top = 0;
            margin.Bottom = 0;
            Button newButton = new Button()
            {
                Margin = margin,
                Content = "A button"
            };
            newButton.Click += StartButton_Click;

            PlayArea.Children.Add(newButton);
        }
        private void NewButtonUp()
        {
            Thickness margin = StartButton.Margin;
            margin.Left = 600;
            margin.Right = 0;
            margin.Top = 400+teller;
            margin.Bottom = 0;
            Button newButton = new Button()
            {
                Margin = margin,
                Content = "A button"
            };
            newButton.Click += StartButton_Click;

            PlayArea.Children.Add(newButton);
        }
        private void NewButtonDown()
        {
            Thickness margin = StartButton.Margin;
            margin.Left = 600;
            margin.Right = 0;
            margin.Top = 0;
            margin.Bottom = 400+teller;
            Button newButton = new Button()
            {
                Margin = margin,
                Content = "A button"
            };
            newButton.Click += StartButton_Click;

            PlayArea.Children.Add(newButton);
        }
    }
}
