using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kalkulator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double equal;
        bool operandPressed;
        string action;
        List<string> operands;
        public MainWindow()
        {
            InitializeComponent();
            equal = .0;
            operandPressed = false;
            action = "";
            operands = new List<string>();
            string[] tmp = { "+", "-", "*", "/", "=", "^2" };
            
            operands.AddRange(tmp.ToList());

        }

        private void btnnumber_Click(object sender, RoutedEventArgs e)
        {
            var data = ((Button)sender).Content.ToString();
            //string dzialanie;
            //dzialanie = data.ToString();
            //if(dzialanie.Contains(operands[0-5]))
            //{
            //    
            //}
            if (operandPressed && !operands.Contains(data))
            {
                operandPressed = false;
                ekran.Text = data;
                return;
            }
            if (operands.Contains(data))
            {
                switch (action)
                {
                    case "+": equal += Convert.ToDouble(ekran.Text); break;
                    case "-": equal -= Convert.ToDouble(ekran.Text); break;
                    case "*": equal *= Convert.ToDouble(ekran.Text); break;
                    case "/": equal /= Convert.ToDouble(ekran.Text); break;
                    case "^2": equal = Convert.ToDouble(ekran.Text) * Convert.ToDouble(ekran.Text); break;

                    default: equal = Convert.ToDouble(ekran.Text); break;
                }
                if (data != "=") action = data;
                ekran.Text = equal.ToString();
                data = "";
                operandPressed = true;
            }
            else
            {
                ekran.Text += data;
            }
        }
        private void asdf(object sender, RoutedEventArgs e)
        {
            ekran.Text = "";
            action = "";
            operandPressed = false;
            equal = 0;
        }
        private void a()
        {

        }
    }
}
