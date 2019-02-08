/* Peter McEwen
 * Febuary 6, 2019
 * My first program in ICS4U
 */
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

namespace _313616HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void BtnGreeting_Click(object sender, RoutedEventArgs e)
        {
            string UserInput = txtName.Text;
            if (UserInput == "Noah" || UserInput == "noah")
            {
                lblOutput.Content = "oi";
            }
            else if (UserInput == "Conner" || UserInput == "conner")
            {
                lblOutput.Content = "hi Conner";
            }
            else if (UserInput == "666")
            {
                Rectangle rectTest = new Rectangle();

                rectTest.Fill = Brushes.Red;
                rectTest.Height = 550;
                rectTest.Width = 800;
                MyCanvas.Children.Add(rectTest);
            }
            else if (UserInput == "meme review")
            {
                lblOutput.Content = "*Clap* *Clap*";
            }
            else
            {
                lblOutput.Content = "Hello " + UserInput;
            }
        }
    }
}
