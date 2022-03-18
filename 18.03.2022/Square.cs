using System;
using System.Collections.Generic;
using System.Text;

namespace _18._03._2022
{
    class Square :Figure
    {
        
        private double _side;
        public double Side
        { 
            get { return _side; }
            set
            {
                do
                {
                    if (value > 0)
                    {
                        _side = value;
                    }

                } while (0>= value);
            }

        }
        public Square(double _side)
        {
            Side = _side;
        }

        public override double CalcArea()
        {
            return Math.Round(Side*Side,2);
        }
       
    } 
}
