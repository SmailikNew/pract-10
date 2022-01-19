using System;
using System.Collections;
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

namespace practice_10
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

        ArrayList numbers = new ArrayList(7);

        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void information(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП-34, Горшков Илья, Вариант 2. Составьте программу вычисления в массиве суммы всех чисел, кратных 7.");
        }

        private void completeListBox(object sender, RoutedEventArgs e)
        {
            tb1.Clear();
            listbox1.Items.Clear();
            numbers.Clear();
            Random rnd = new Random();
            for (int i = 0; i < 7; i++)
            {
                numbers.Add(rnd.Next(0, 100));
                listbox1.Items.Add(numbers[i]);
            }
        }


        private void sumMultiplesOfSeven(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            foreach (int item in numbers)
            {
                if (item % 7 == 0)
                {
                    sum += item;
                }
            }
            tb1.Text = "Сумма чисел кратных 7 в массиве = " + sum;
        }

        private void clear(object sender, RoutedEventArgs e)
        {
            tb1.Clear();
            listbox1.Items.Clear();
            numbers.Clear();
        }
    }
}
