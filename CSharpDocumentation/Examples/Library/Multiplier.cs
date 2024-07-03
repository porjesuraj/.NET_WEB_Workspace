using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Library
{

   delegate double Function(double x);
    internal class Multiplier
    {

        double _factor;

        public Multiplier(double factor) => _factor = factor;

        public double Multiply(double x) => x * _factor;

    }


}
