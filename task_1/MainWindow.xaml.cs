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
    ///                 Тема «Контейнеры компоновки»
    ///                         Задание 1
    /// Разработать WPF-приложение, содержащее набор кнопок, занимающих
    /// 2/3 ширины окна при любых его размерах. Каждая кнопка должна в качестве
    /// содержимого отображать название цвета и обладать наружным отступом,
    /// равным 2.0. Также соответствующий цвет должен использоваться в качестве
    /// цвета переднего плана кнопки. Необходимо использовать следующий набор
    /// цветов: Navy, Blue, Aqua, Teal, Olive, Green, Lime, Yellow, Orange, Red, Maroon,
    /// Fuchsia, Purple, Black, Silver, Gray, White.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
