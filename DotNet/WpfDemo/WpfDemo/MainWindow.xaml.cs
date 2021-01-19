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

namespace WpfDemo
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int luku1 = int.Parse(luku1TextBox.Text);
            int luku2 = int.Parse(luku2TextBox.Text);

            int summa = luku1 + luku2;
            MessageBox.Show("Summa on: " + summa);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int luku1 = int.Parse(luku1TextBox.Text);
            int luku2 = int.Parse(luku2TextBox.Text);

            int erotus = luku1 - luku2;
            MessageBox.Show("Erotus on: " + erotus);
        }
    }
}
