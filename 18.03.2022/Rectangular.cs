using System;
using System.Collections.Generic;
using System.Text;

namespace _18._03._2022
{
    class Rectangular:Figure
    {
        private double _width;
        private double _length;
        

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                do
                {
                    if (value > 0)
                    {
                        _width =value;
                    }

                } while (value <= 0);
            } 
        }
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                do
                {
                    if (value>0)
                    {
                        _length = value;
                    }

                } while (value <= 0);
            }
        }
        public Rectangular(double _width,double _length)
        {
            Width = _width;
            Length = _length;
        }
       

        public override double CalcArea()
        {
            return Math.Round(Width*Length,2);
        }
    }
}
