using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace калькулятор
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Class1 podschet = new Class1();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_a_TextChanged(object sender, TextCompositionEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
                                    
            if (TextBox_a.Text != string.Empty && TextBox_b.Text != string.Empty && TextBox_c.Text != string.Empty)
            {
                if (!Char.IsDigit(TextBox_a.Text, 0) || !Char.IsDigit(TextBox_b.Text, 0) || !Char.IsDigit(TextBox_c.Text, 0))
                {
                    MessageBox.Show("Треугольник не существует");
                    TextBox_a.Clear();
                    TextBox_b.Clear(); 
                    TextBox_c.Clear();
                }
                else
                {
                    var a = Convert.ToInt32(TextBox_a.Text);
                    var b = Convert.ToInt32(TextBox_b.Text);
                    var c = Convert.ToInt32(TextBox_c.Text); 
                    if (podschet.Check(a, b, c) != 0)
                    {
                        MessageBox.Show(
                            $"\nПервая сторона (a) = {a}" +
                            $"\nВторая сторона (b) = {b}" +
                            $"\nТретья сторона (c) = {c}" +
                            $"\n\nПериметр (P) = {podschet.Check(a, b, c)}" +
                        $"\nПлощадь (S) = { Math.Round(podschet.Area(a, b, c), 3) }");                    
                    }
                    else
                    {
                        MessageBox.Show("Треугольник не существует!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Некоторые данные не заполнены!");
                TextBox_a.Clear();
                TextBox_b.Clear();
                TextBox_c.Clear();
            }
        }
    }
}
