using System.Windows;

namespace task_3;

/// <summary>
///     Interaction logic for MainWindow.xaml
/// </summary>
/// <summary>
///     Task 3
///     Develop a WPF application to compute the determinant of a 3x3 matrix.
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
        if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" ||
            TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "" ||
            TextBox9.Text == "")
        {
            MessageBox.Show("Enter all the values", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        // Check for a number.
        if (!double.TryParse(TextBox1.Text, out var a11) || !double.TryParse(TextBox2.Text, out var a12) ||
            !double.TryParse(TextBox3.Text, out var a13) || !double.TryParse(TextBox4.Text, out var a21) ||
            !double.TryParse(TextBox5.Text, out var a22) || !double.TryParse(TextBox6.Text, out var a23) ||
            !double.TryParse(TextBox7.Text, out var a31) || !double.TryParse(TextBox8.Text, out var a32) ||
            !double.TryParse(TextBox9.Text, out var a33))
        {
            MessageBox.Show("Enter only numbers", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        // Calculation of the determinant.
        var result = a11 * a22 * a33 + a12 * a23 * a31 + a13 * a21 * a32 - a13 * a22 * a31 - a12 * a21 * a33 -
                     a11 * a23 * a32;

        // Output of the result in label.
        LabelResult.Content = result;
    }
}