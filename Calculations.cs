using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace UncertaintyCalculator
{
    class Calculations
    {
        public double findPlusMinusDelta(double i1, double i2, double f1, double f2) {
            double avgDiff1 = (i2 - i1) / 2;
            double avgDiff2 = (f2 - f1) / 2;

            return Math.Sqrt(Math.Pow(avgDiff1, 2) + Math.Pow(avgDiff2, 2));
        }

        public double findTwoNumAvg(double v1, double v2) {
            return (v1 + v2) / 2;
        }

        public double findMultiDivDelta(double z, double x, double y, double deltaX, double deltaY) {
            return z * Math.Sqrt(Math.Pow(deltaX / x, 2) + Math.Pow(deltaY / y, 2));            
        }

        public double findPowDelta(double z, double x, double deltaX, double power) {
            return z * power * (deltaX / x);
        }

        public double findFinalValue(double v1, double v2) {
            return v2 - v1;
        }
    }
}
