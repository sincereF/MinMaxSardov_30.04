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

namespace MinMaxSardov
{
    // Описать функцию NMin(A,N) и NMax(A,N) целого типа, находящую номер минимального и максимального элемента массива A
    // (массив состоит из N вещественных чисел). 


    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void masButton_Click(object sender, RoutedEventArgs e)
        {
            Classes.Completion completion = new Classes.Completion();
            completion.completion(this);
        }
    }
}