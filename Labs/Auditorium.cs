using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Auditorium
    {
        private double length;
        private double width;
        private double height;
        private int numberOfComputers;


        public Auditorium(double length, double width, double height, int numberOfComputers)
        {
            this.length = length;
            this.width = width;
            this.height = height;
            this.numberOfComputers = numberOfComputers;
        }

        public Auditorium()
        {
            length = 10.0; 
            width = 8.0;   
            height = 3.0; 
            numberOfComputers = 5; 
        } 

        public double Length
        {
            get { return length; }
            set
            {
                if (value > 0)
                    length = value;
                else
                    throw new ArgumentException("Довжина повинна бути більше 0.");
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                    width = value;
                else
                    throw new ArgumentException("Ширина повинна бути більше 0.");
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                    height = value;
                else
                    throw new ArgumentException("Висота стелі повинна бути більше 0.");
            }
        }

        public int NumberOfComputers
        {
            get { return numberOfComputers; }
            set
            {
                if (value >= 0)
                    numberOfComputers = value;
                else
                    throw new ArgumentException("Кількість комп'ютерів не може бути від'ємною.");
            }
        }

       

        public double CalculateArea()
        {
            return Length * Width;
        }

        public double CalculateVolume()
        {
            return Length * Width * Height;
        }

        public bool MeetSanitaryNorms()
        {
            double areaPerComputer = CalculateArea() / NumberOfComputers;
            return areaPerComputer >= 6;
        }
    }
}