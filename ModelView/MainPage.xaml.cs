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

namespace ModelView
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MemberViewModel MemberViewModel { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            MemberViewModel = new MemberViewModel(new Member()
            { FirstName = "Tante", LastName = "Sidonia", BirthDate = new DateTimeOffset(new DateTime(1968,1,1))});
            
        }

        

        private void Button_Change(object sender, RoutedEventArgs e)
        {
            MemberViewModel.FirstName = "Jeff";
            MemberViewModel.LastName = "Jefferson";
            MemberViewModel.BirthDate = new DateTimeOffset(new DateTime(1990,1,1));
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            MemberList.Items.Add(FirstNameTxt.Text + " " + LastNameTxt.Text + "\n" + BdayPicker.Date);
        }
    }
}
