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

namespace CalculateApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int income;
        int expense;
        float minus;
        int price;
        float result;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            income = int.Parse(txtIncome.Text);
            expense = int.Parse(txtExpenses.Text);
            price = int.Parse(txtPrice.Text);
            minus = income - expense;
            result = price / minus;
            txtDays.Text = result.ToString();
        }
    }
}
