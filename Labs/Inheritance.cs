using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using System;

namespace Labs
{
    public class Phone
    {
   
        private int numberOfFunctions;

        public Phone(int functions)
        {
            numberOfFunctions = functions;
        }

        public int GetNumberOfFunctions()
        {
            return numberOfFunctions;
        }

      
        public virtual double GetCost()
        {
            return 40 * Math.Log(numberOfFunctions);
        }

 
        public void DisplayPhoneDetails()
        {
            MessageBox.Show($"Кількість функцій: {numberOfFunctions}\nЦіна: {GetCost()}");
        }
    }

    // Похідний клас
    public class Mobile : Phone
    {
 
        private string model;

        public Mobile(int functions, string mobileModel) : base(functions)
        {
            model = mobileModel;
        }

        public override double GetCost()
        {
            return base.GetCost() * 3;
        }

        public new void DisplayPhoneDetails()
        {
            MessageBox.Show($"Модель: {model}\nЦіна: {GetCost()}");
        }
    }
}
