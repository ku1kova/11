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
using System.Text.RegularExpressions;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.Content = "Введите имя латиницей и в нижнем регистре";
            textBoxName.ToolTip = toolTip;
        }
        private void buttonSubmit_Click(object sender, RoutedEventArgs e)
        {
            string inputName = textBoxName.Text;
            if (string.IsNullOrWhiteSpace(inputName) || !IsLatinLowercase(inputName))
            {
                MessageBox.Show("Неверно! Введите имя латиницей и в нижнем регистре.",
                                "Ошибка ввода",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Имя успешно введено: " + inputName,
                                "Успех",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
        }
        private bool IsLatinLowercase(string input)
        {
            return Regex.IsMatch(input, "^[a-z]+$");
        }
    }
}
