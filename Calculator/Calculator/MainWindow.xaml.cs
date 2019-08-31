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

namespace Calculator
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
        }
        public float answer;
        private void Kareal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {

        }

        public void AllProcess_Click(object sender, RoutedEventArgs e)
        {
            
            if (!IsNumeric(process.Text.Substring(process.Text.Length - 1, 1)))
            {
                process.Text = process.Text.Substring(0, process.Text.Length - 1) + ((Button)sender).Content.ToString();
            }
            else if (!IsNumeric(process.Text))
            {
                char[] proc = { '+', '-', 'x', '÷' };
                string type_proc = process.Text.IndexOfAny(proc).ToString();
                if (type_proc != "-1")
                {
                    
                    if (process.Text.Substring(Convert.ToInt32(type_proc), 1) == "+")
                    {
                        answer = float.Parse(process.Text.Substring(0, Convert.ToInt32(type_proc))) + float.Parse(process.Text.Substring(Convert.ToInt32(type_proc) + 1));
                    }
                    else if (process.Text.Substring(Convert.ToInt32(type_proc), 1) == "-")
                    {
                        answer = float.Parse(process.Text.Substring(0, Convert.ToInt32(type_proc))) - float.Parse(process.Text.Substring(Convert.ToInt32(type_proc) + 1)); 
                    }
                    else if (process.Text.Substring(Convert.ToInt32(type_proc), 1) == "x")
                    {
                        answer = float.Parse(process.Text.Substring(0, Convert.ToInt32(type_proc))) * float.Parse(process.Text.Substring(Convert.ToInt32(type_proc) + 1));
                    }
                    else if (process.Text.Substring(Convert.ToInt32(type_proc), 1) == "÷")
                    {
                        answer = float.Parse(process.Text.Substring(0, Convert.ToInt32(type_proc))) / float.Parse(process.Text.Substring(Convert.ToInt32(type_proc) + 1));
                    }
                    process.Text = Convert.ToString(answer);
                }
            }
            else
            {
                process.Text += ((Button)sender).Content.ToString();
            }
        }

        private void Esittir_Click(object sender, RoutedEventArgs e)
        {
            if (!IsNumeric(process.Text.Substring(process.Text.Length - 1, 1)))
            {
                process.Text = process.Text.Substring(0, process.Text.Length - 1);
            }
            else if (!IsNumeric(process.Text))
            {
                char[] proc = { '+', '-', 'x', '÷' };
                string type_proc = process.Text.IndexOfAny(proc).ToString();
                if (type_proc != "-1")
                {

                    if (process.Text.Substring(Convert.ToInt32(type_proc), 1) == "+")
                    {
                        answer = float.Parse(process.Text.Substring(0, Convert.ToInt32(type_proc))) + float.Parse(process.Text.Substring(Convert.ToInt32(type_proc) + 1));
                    }
                    else if (process.Text.Substring(Convert.ToInt32(type_proc), 1) == "-")
                    {
                        answer = float.Parse(process.Text.Substring(0, Convert.ToInt32(type_proc))) - float.Parse(process.Text.Substring(Convert.ToInt32(type_proc) + 1));
                    }
                    else if (process.Text.Substring(Convert.ToInt32(type_proc), 1) == "x")
                    {
                        answer = float.Parse(process.Text.Substring(0, Convert.ToInt32(type_proc))) * float.Parse(process.Text.Substring(Convert.ToInt32(type_proc) + 1));
                    }
                    else if (process.Text.Substring(Convert.ToInt32(type_proc), 1) == "÷")
                    {
                        answer = float.Parse(process.Text.Substring(0, Convert.ToInt32(type_proc))) / float.Parse(process.Text.Substring(Convert.ToInt32(type_proc) + 1));
                    }
                    process.Text = Convert.ToString(answer);
                }
            }
        }

        private void Eksi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Virgul_Click(object sender, RoutedEventArgs e)
        {

        }

        public static bool IsNumeric(string s)
        {
            float output;
            return float.TryParse(s, out output);
        }

        public void AllNumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsNumeric(process.Text.Substring(process.Text.Length - 1, 1)))
            {
                if (process.Text == "0")
                {
                    process.Text = "" + ((Button)sender).Content.ToString();
                }
                else if (process.Text.Substring(process.Text.Length - 1, 1) == "0")
                {
                    process.Text = process.Text.Substring(0, process.Text.Length - 1) + ((Button)sender).Content.ToString();
                }
                else
                {
                    process.Text += ((Button)sender).Content.ToString();
                }
            }
            else
            {
                process.Text += ((Button)sender).Content.ToString();
            }
        }
    }
}
