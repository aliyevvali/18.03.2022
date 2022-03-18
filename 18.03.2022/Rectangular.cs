using System;
using System.Collections.Generic;
using System.Text;

namespace _18._03._2022
{
    class Rectangular : Figure
    {
        private double _width;
        private double _length;


        //public double Width
        //{
        //    get
        //    {
        //        return _width;
        //    }
        //    set
        //    {
        //      if (value > 0 )
        //      {
        //          _width = value;
        //      }               
        //    }
        //}
        //public double Length
        //{
        //    get
        //    {
        //        return _length;
        //    }
        //    set
        //    {
        //        if (value > 0 )
        //        {
        //            _length = value;
        //        }                
        //    }
        //}
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangular(double _width, double _length)
        {
            Width = _width;
            Length = _length;
        }


        public override double CalcArea()
        {
            if (Width>0 && Length>0)
            {
               return Math.Round(Width * Length, 2);
            }
            return 0;
           
        }
    }
}
