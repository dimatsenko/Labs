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

namespace Labs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                double length = Convert.ToDouble(Length.Text);
                double width = Convert.ToDouble(Width.Text);
                double height = Convert.ToDouble(Height.Text);
                int numberOfComputers = Convert.ToInt32(Number.Text);

                
                Auditorium auditorium = new Auditorium(length, width, height, numberOfComputers);

                double area = auditorium.CalculateArea();
                double volume = auditorium.CalculateVolume();
                bool meetsSanitaryNorms = auditorium.MeetSanitaryNorms();

                MessageBox.Show($"Площа: {area} м²\n" +
                    $"Об'єм: {volume} м³\n" +
                    $"Санітарні норми: {(meetsSanitaryNorms ? "Відповідає" : "Не відповідає")}");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}. Будь ласка, введіть коректні числові значення.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }

        private void InheritanceButton_Click(object sender, RoutedEventArgs e)
        {
            var InheritanceWindow = new Window1();
            this.Hide();
            InheritanceWindow.Show();
        }
    }
}