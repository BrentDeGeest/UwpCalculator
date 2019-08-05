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

namespace Rekenmachine
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

        char[] delimiterChars = { '+', '/', '*' };
        Calculation calc = new Calculation();

        double num1;
        double num2;

        string oper;
        string history;
        bool inputNumber = false;

        private void GetNumber() // Zet num1 of num2 op het nummer in de textbox
        {
            string[] nummers = ResultTextBox.Text.Split(delimiterChars);
            foreach (string num in nummers)
            {
                calc.ConvertNumbers(ref num1, ref num2, num);
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (ResultTextBox.Text.Length < 10 || num1 != 0)
                ResultTextBox.Text += '1'; history += "1";
            inputNumber = true;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (ResultTextBox.Text.Length < 10)
                ResultTextBox.Text += '2'; history += "2";
            inputNumber = true;

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (ResultTextBox.Text.Length < 10)
                ResultTextBox.Text += '3'; history += "3";
            inputNumber = true;

        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (ResultTextBox.Text.Length < 10)
                ResultTextBox.Text += '4'; history += "4";
            inputNumber = true;

        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (ResultTextBox.Text.Length < 10)
                ResultTextBox.Text += '5'; history += "5";
            inputNumber = true;

        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (ResultTextBox.Text.Length < 10)
                ResultTextBox.Text += '6'; history += "6";
            inputNumber = true;

        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (ResultTextBox.Text.Length < 10)
                ResultTextBox.Text += '7'; history += "7";
            inputNumber = true;

        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (ResultTextBox.Text.Length < 10)
                ResultTextBox.Text += '8'; history += "8";
            inputNumber = true;

        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (ResultTextBox.Text.Length < 10)
                ResultTextBox.Text += '9'; history += "9";
            inputNumber = true;

        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (ResultTextBox.Text.Length < 10)
                ResultTextBox.Text += '0'; history += "0";
            inputNumber = true;

        }

        private void Reset()
        {
            ResultTextBox.Text = "";
            InputTextBox.Text = "";
            num1 = 0;
            num2 = 0;
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ResultTextBox.Text = ResultTextBox.Text.Remove(ResultTextBox.Text.Length - 1);
            }
            catch (Exception)
            {
                // Doe niets wanneer er geen nummers meers zijn om te verwijderen.
            }
        }

        private void DeelButton_Click(object sender, RoutedEventArgs e)
        {
            GetNumber();

            oper = "/";
            InputTextBox.Text = num1.ToString() + " / ";
            ResultTextBox.Text = ""; history += " / ";
        }

        private void MaalButton_Click(object sender, RoutedEventArgs e)
        {
            GetNumber();

            oper = "*";
            InputTextBox.Text = num1.ToString() + " * ";
            ResultTextBox.Text = ""; history += " * ";
        }

        private void MinButton_Click(object sender, RoutedEventArgs e)
        {
            GetNumber();

            oper = "-";
            InputTextBox.Text = num1.ToString() + " - ";
            ResultTextBox.Text = ""; history += " - ";
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            GetNumber();
            if(num2 != 0)
            {
                GelijkButton_Click(sender, e);
            }
            oper = "+";
            InputTextBox.Text = num1.ToString() + " + ";
            ResultTextBox.Text = "";
            history += " + ";
        }

        private void GelijkButton_Click(object sender, RoutedEventArgs e)
        {
            GetNumber();
            InputTextBox.Text += ResultTextBox.Text;
            double tempNum2 = num2;
            if (inputNumber == false)
            {
                history = num1.ToString() + oper + tempNum2.ToString();
            }
            switch (oper)
            {
                case "+": num1 += num2; num2 = 0; break;
                case "-": num1 -= num2; num2 = 0; break;
                case "*": num1 *= num2; num2 = 0; break;
                case "/": num1 /= num2; num2 = 0; break;
                default: break;
            }
            InputTextBox.Text = num1.ToString();
            
            history += " = " + InputTextBox.Text;
            GeschiedenisTextBox.Items.Add( history);
            inputNumber = false;
        }

        private void PuntButton_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBox.Text += ","; history += ",";
        }

        private void PosNegButton_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBox.Text = calc.PosNeg(ResultTextBox.Text);
            history = calc.PosNeg(history);
        }

        private void ClearHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            GeschiedenisTextBox.Items.Clear();
        }
    }
}
