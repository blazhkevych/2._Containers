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
    ///                             Задание 2
    /// Разработать WPF-приложение для ввода шифра. У правой границы окна
    /// должна быть расположена цифровая панель. При изменении размеров окна
    /// поле ввода цифр должно занимать все свободное пространство окна.
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
