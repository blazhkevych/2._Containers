﻿using System;
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
            // 2:56:30 about second task
            // Добавление цифры в поле ввода из кнопок, где значение content от 0 до 9.
            // Adding a digit to the input field from the buttons, where the value content is from 0 to 9.
            if (sender is Button button)
            {
                if (button.Content is string content)
                {
                    if (content[0] >= '0' && content[0] <= '9')
                    {
                        TextBox1.Text += content;
                    }
                }
            }
        }
    }
}
