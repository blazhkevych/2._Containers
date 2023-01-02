using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace task_1;

/// <summary>
///     Interaction logic for MainWindow.xaml
/// </summary>
/// <summary>
/// Тема «Контейнеры компоновки»
/// Задание 1
/// Разработать WPF-приложение, содержащее набор кнопок, занимающих 2/3 ширины окна при любых его размерах.
/// Каждая кнопка должна в качестве содержимого отображать название цвета и обладать наружным отступом, равным 2.0.
/// Также соответствующий цвет должен использоваться в качестве цвета переднего плана кнопки.
/// Необходимо использовать следующий набор цветов: Navy, Blue, Aqua, Teal, Olive, Green, Lime, Yellow, Orange, Red, Maroon,
/// Fuchsia, Purple, Black, Silver, Gray, White.
///
/// Layout Containers topic
/// Exercise 1
/// Develop a WPF application containing a set of buttons that take up 2/3 of the width of the window at any size.
/// Each button should display the name of the color as content and have an outer padding of 2.0.
/// Also the corresponding color should be used as the foreground color of the button.
/// The following color set must be used: Navy, Blue, Aqua, Teal, Olive, Green, Lime, Yellow, Orange, Red, Maroon,
/// Fuchsia, Purple, Black, Silver, Gray, White.
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
}