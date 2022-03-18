using System;
using System.Collections.Generic;
using System.Text;

namespace _18._03._2022
{
    class Square :Figure
    {
        
        private double _side;
        //public double Side
        //{ 
        //    get { return _side; }
        //    set
        //    {                             
        //       if (value > 0)
        //       {
        //           _side = value;
        //       }               
        //    }

        //}
        public double Side { get; set; }
        public Square(double _side)
        {
            Side = _side;
        }

        public override double CalcArea()
        {
            if (Side >0)
            {
                return Math.Round(Side * Side, 2);
            }
            return 0;
        }
       
    } 
}
