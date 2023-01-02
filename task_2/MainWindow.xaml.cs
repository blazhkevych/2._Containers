using System.Windows;
using System.Windows.Controls;

namespace task_2;

/// <summary>
///     Interaction logic for MainWindow.xaml
/// </summary>
/// <summary>
///     Task 2
///     Develop a WPF application for entering a ciphers.
///     A number pad should be located at the right border of the window.
///     When resizing the window, the number input field must occupy all the free space of the window.
/// </summary>
public partial class MainWindow : Window
{
    // Variable for storing a password.
    private readonly string _password = "12345";

    public MainWindow()
    {
        InitializeComponent();
    }

    // Handler for the event of pressing the number pad button.
    private void ButtonNumbersClickEvent(object sender, RoutedEventArgs e)
    {
        // Adding a digit to the input field from the buttons, where the value content is from 0 to 9.
        if (sender is Button button)
            if (button.Content is string content)
                if (content[0] >= '0' && content[0] <= '9')
                    TextBox1.Text += content;
    }

    // Handler for the event of pressing the "Clear" button.
    private void ButtonC_OnClickClickEvent(object sender, RoutedEventArgs e)
    {
        TextBox1.Text = "";
    }

    // Handler for the event of pressing the "OK" button.
    private void ButtonOk_OnClickClickEvent(object sender, RoutedEventArgs e)
    {
        if (TextBox1.Text == _password)
            MessageBox.Show("Password correct", "Password", MessageBoxButton.OK, MessageBoxImage.Information);
        else
            MessageBox.Show("Wrong password", "Password", MessageBoxButton.OK, MessageBoxImage.Error);
    }
}