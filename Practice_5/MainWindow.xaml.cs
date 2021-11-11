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

namespace Practice_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    
        private void Сalculate2Pair_Click(object sender, RoutedEventArgs e)
        {
            Pair firstPair = new Pair(int.Parse(firstP1.Text), int.Parse(secondP1.Text));
            Pair secondPair = new Pair(int.Parse(firstP2.Text), int.Parse(secondP2.Text));
            Pair resultPair = firstPair.Substract(secondPair);
            result.Text = (resultPair.First, resultPair.Second).ToString();
        }

        private void Сalculate3Pair_Click(object sender, RoutedEventArgs e)
        {
            Pair firstPair = new Pair(int.Parse(firstP1.Text), int.Parse(secondP1.Text));
            Pair secondPair = new Pair(int.Parse(firstP2.Text), int.Parse(secondP2.Text));
            Pair thirdPair = new Pair(int.Parse(firstP3.Text), int.Parse(secondP3.Text));
            Pair resultPair = firstPair.Substract(secondPair, thirdPair);
            result.Text = (resultPair.First, resultPair.Second).ToString();
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            Pair firstPair = new Pair(int.Parse(firstP1.Text), int.Parse(secondP1.Text));
            result.Text = firstPair.Multiply().ToString();
        }

        private void IsPeer_Click(object sender, RoutedEventArgs e)
        {
            Pair firstPair = new Pair(int.Parse(firstP1.Text), int.Parse(secondP1.Text));
            result.Text = firstPair.IsEuqual().ToString();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Золотарев М. А.\n Группа: ИСП-34\n Вариант №13", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
