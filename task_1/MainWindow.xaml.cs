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

namespace task_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    /// <summary>
    ///                 Тема «Контейнеры компоновки»                                                                                  /// Layout Containers topic
    ///                         Задание 1                                                                                             ///                         Exercise 1
    /// Разработать WPF-приложение, содержащее набор кнопок, занимающих 2/3 ширины окна при любых его размерах.                       /// Develop a WPF application containing a set of buttons that take up 2/3 of the width of the window at any size.
    /// Каждая кнопка должна в качестве содержимого отображать название цвета и обладать наружным отступом, равным 2.0.               /// Each button should display the name of the color as content and have an outer padding of 2.0.
    /// Также соответствующий цвет должен использоваться в качестве цвета переднего плана кнопки.                                     /// Also the corresponding color should be used as the foreground color of the button.
    /// Необходимо использовать следующий набор цветов: Navy, Blue, Aqua, Teal, Olive, Green, Lime, Yellow, Orange, Red, Maroon,      /// The following color set must be used: Navy, Blue, Aqua, Teal, Olive, Green, Lime, Yellow, Orange, Red, Maroon,       
    /// Fuchsia, Purple, Black, Silver, Gray, White.                                                                                  /// Fuchsia, Purple, Black, Silver, Gray, White.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
