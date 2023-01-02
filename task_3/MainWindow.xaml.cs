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

namespace task_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    /// <summary>
    /// Task 3
    /// Develop a WPF application to compute the determinant of a 3x3 matrix.
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Handler for the event of pressing the "ButtonResult" button.
        private void ButtonResult_OnClick(object sender, RoutedEventArgs e)
        {
            // Check for the presence of data in the input fields.
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "" || TextBox9.Text == "")
            {
                MessageBox.Show("Enter all the values", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Check for a number.
            if (!double.TryParse(TextBox1.Text, out double a11) || !double.TryParse(TextBox2.Text, out double a12) || !double.TryParse(TextBox3.Text, out double a13) || !double.TryParse(TextBox4.Text, out double a21) || !double.TryParse(TextBox5.Text, out double a22) || !double.TryParse(TextBox6.Text, out double a23) || !double.TryParse(TextBox7.Text, out double a31) || !double.TryParse(TextBox8.Text, out double a32) || !double.TryParse(TextBox9.Text, out double a33))
            {
                MessageBox.Show("Enter only numbers", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Calculation of the determinant.
            double result = a11 * a22 * a33 + a12 * a23 * a31 + a13 * a21 * a32 - a13 * a22 * a31 - a12 * a21 * a33 - a11 * a23 * a32;

            // Output of the result in label.
            LabelResult.Content = result;
        }
    }
}
