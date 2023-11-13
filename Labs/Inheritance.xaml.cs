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
using System.Windows.Shapes;

namespace Labs
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void BaseClassButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Отримання значення кількості функцій для базового класу
                int numberOfFunctions = int.Parse(t1.Text);

                // Створення об'єкта базового класу та виведення результатів
                Phone basePhone = new Phone(numberOfFunctions);
                basePhone.DisplayPhoneDetails();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }

        private void DerivedClassButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Отримання значень кількості функцій і моделі для похідного класу
                int numberOfFunctions = int.Parse(t2.Text);
                string model = t3.Text;

                // Створення об'єкта похідного класу та виведення результатів
                Mobile mobilePhone = new Mobile(numberOfFunctions, model);
                mobilePhone.DisplayPhoneDetails();
                          
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
    }
}


