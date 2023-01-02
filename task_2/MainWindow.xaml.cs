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

namespace task_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    /// <summary>
    ///                             Задание 2                                                              /// Task 2
    /// Разработать WPF-приложение для ввода шифра.                                                        /// Develop a WPF application for entering a cipher.
    /// У правой границы окна должна быть расположена цифровая панель.                                     /// A number pad should be located at the right border of the window.
    /// При изменении размеров окна поле ввода цифр должно занимать все свободное пространство окна.       /// When resizing the window, the number input field must occupy all the free space of the window.
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button7ClickEvent(object sender, RoutedEventArgs e)
        {
            // Добавляем цифру 7 в поле ввода/
            TextBox1.Text += "7";
        }
    }
}
