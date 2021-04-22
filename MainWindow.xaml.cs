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

namespace New
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string global;
        string global_char;

        string[] subs_char = new string[10];
        string[] subs = new string[10];

        public MainWindow()
        {
            InitializeComponent();


            
        }



        static int Function(string[] subs_char, string[] subs)
        {
            int res = 0;



            if (subs_char[0] == "+")
            {
                res = Convert.ToInt32(subs[0]) + Convert.ToInt32(subs[1]);
            }
            if (subs_char[0] == "-")
            {
                res = Convert.ToInt32(subs[0]) - Convert.ToInt32(subs[1]);
            }
            if (subs_char[0] == "*")
            {
                res = Convert.ToInt32(subs[0]) * Convert.ToInt32(subs[1]);
            }
            if (subs_char[0] == "/")
            {
                res = Convert.ToInt32(subs[0]) / Convert.ToInt32(subs[1]);
            }


            if(subs_char.Length == 3) {
                Console.WriteLine(subs_char[1]);
            if (subs_char[1] == "+")
            {
                res = res + Convert.ToInt32(subs[2]);
            }
            if (subs_char[1] == "-")
            {
                res = res - Convert.ToInt32(subs[2]);
            }
            if (subs_char[1] == "*")
            {
                res = res * Convert.ToInt32(subs[2]);
            }
            if (subs_char[1] == "/")
            {
                res = res / Convert.ToInt32(subs[2]);
            }
            }







            return res;
        }



        private void button_equally_Click(object sender, RoutedEventArgs e)
        {
            Array.Resize(ref subs_char, 10);
            Array.Resize(ref subs_char, 10);
            subs_char = global_char.Split(';');

            subs = global.Split('+', '-', '/', '*');

            result.Text = Convert.ToString(Function(subs_char, subs));




        }

        private void button_0_Click(object sender, RoutedEventArgs e)
        {
            global = global + "0";
            operations.Text = global;
        }

        private void button_dot_Click(object sender, RoutedEventArgs e)
        {
            global = global + ".";
            operations.Text = global;
        }

    

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            global = global + "+";
            operations.Text = global;

            global_char = global_char + "+;";
        }

        private void button_3_Click(object sender, RoutedEventArgs e)
        {
            global = global + "3";
             operations.Text = global;
        }

        private void button_2_Click(object sender, RoutedEventArgs e)
        {
            global = global + "2";
            operations.Text = global;
        }

        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            global = global + "1";
            operations.Text = global;
        }

        private void button_min_Click(object sender, RoutedEventArgs e)
        {
            global = global + "-";
            operations.Text = global;

            global_char = global_char + "-;";
        }

        private void button_6_Click(object sender, RoutedEventArgs e)
        {
            global = global + "6";
            operations.Text = global;
        }

        private void button_5_Click(object sender, RoutedEventArgs e)
        {
            global = global + "5";
            operations.Text = global;
        }

        private void button_4_Click(object sender, RoutedEventArgs e)
        {
            global = global + "4";
            operations.Text = global;
        }

        private void button_x_Click(object sender, RoutedEventArgs e)
        {
            global = global + "*";
            operations.Text = global;

            global_char = global_char + "*;";
        }

        private void button_9_Click(object sender, RoutedEventArgs e)
        {
            global = global + "9";
            operations.Text = global;
        }

        private void button_8_Click(object sender, RoutedEventArgs e)
        {
            global = global + "8";
            operations.Text = global;
        }

        private void button_7_Click(object sender, RoutedEventArgs e)
        {
            global = global + "7";
            operations.Text = global;
        }

        private void button_div_Click(object sender, RoutedEventArgs e)
        {
            global = global + "/";
            operations.Text = global;

            global_char = global_char + "/;";
        }

        private void button_arrow_Click(object sender, RoutedEventArgs e)
        {
            global = global + "<";
            operations.Text = global;
        }

        private void button_C_Click(object sender, RoutedEventArgs e)
        {
            
            global = global.Remove(global.Length-1);
            operations.Text = global;
        }

        private void button_CE_Click(object sender, RoutedEventArgs e)
        {
            global = "";
            operations.Text = global;

                Array.Resize(ref subs_char, 0);
                Array.Resize(ref subs, 0);


        }
    }
}
