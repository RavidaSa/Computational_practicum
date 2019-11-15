using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_Comp
{
    public struct PointD
    {
        public double X { get; set; }
        public double Y { get; set; }
        public PointD(double x, Double y)
        {
            X = x;
            Y = y;
        }
    }

    // TODO: Create abstract class method
    // TODO: Make the inheritance 
    // TODO: locate corresponding functions
    // TODO: Create exact solution method


    public abstract class Method
    {
        internal abstract List<PointD>[] Solve(double x0, double y0, double max, int num, int max_er);
        public double orig(double x, double y) {
            return (Math.Exp(y) - 2 / x);
        }
    }
    public class Exact
    {
        internal static List<PointD> Solve(double x0, double y0, double max, int num)
        {
            List<PointD> result = new List<PointD>();
            double h = (max - x0) / num; //step size
            double c = find_c(x0, y0);
            PointD point =  new PointD();
            while (x0 < max)
            {
                if (x0 == 0) { x0 += h; continue; }
                point.X = x0;
                point.Y = (-1)*Math.Log(x0+c*Math.Pow(x0,2));
                result.Add(point);
                x0 += h;
            }
            return result;

        }

        public double getValue(double x, double x0, double y0)
        {
            return (-1) * Math.Log(x + find_c(x0, y0) * Math.Pow(x, 2));
        }

        private static double find_c(double x0, double y0)
        {
            return ((1-Math.Exp(y0)*x0)/(Math.Pow(x0,2)*Math.Exp(y0)));
        }

 
    }
    public class Euler : Method
    {
        internal override List<PointD>[] Solve(double x0, double y0, double max, int num, int max_er)
        {
            double h = (max - x0) / num; //step size
            PointD point = new PointD();
            Exact exacEquation = new Exact();

            List<PointD>[] result = new List<PointD>[3]; //creating a list 
            result[0] = new List<PointD>(); // List for points of Euler's method grapgh
            result[1] = new List<PointD>(); // List for local errors of the Euler's method
            result[2] = new List<PointD>(); // List for global error plotting

            double x = x0, y = y0;
            while (x <= max) //Euler's method
            {
                point.X = x;
                point.Y = y;
                result[0].Add(point);
                double localError = Math.Abs(y - exacEquation.getValue(x, x0, y0));
                point.X = x;
                point.Y = localError;
                result[1].Add(point);
                y = y + h * orig(x, y);
                x = x + h;
            }

            //global error
            for (int i = 0; i < max_er; i++)
            {
                x = x0;
                y = y0;
                h = (max - x0) / (i + 1);
                for (int j = 0; j < i + 1; j++)
                {
                    y = y + h * orig(x, y);
                    x = x + h;
                }
                if (i > 1)
                {
                    double globalError = Math.Abs(y - exacEquation.getValue(x, x0, y0));
                    point.X = i;
                    point.Y = globalError;
                    result[2].Add(point);
                }
            }


            return result;
        }
    }
    public class Euler_ex : Method
    {
        internal override List<PointD>[] Solve(double x0, double y0, double max, int num, int max_er)
        {
            double h = (max - x0) / num; //step size
            PointD point = new PointD();
            Exact exacEquation = new Exact();

            List<PointD>[] result = new List<PointD>[3]; //creating a list 
            result[0] = new List<PointD>(); // List for points of Euler's method grapgh
            result[1] = new List<PointD>(); // List for local errors of the Euler's method
            result[2] = new List<PointD>(); // List for global error plotting

            double x = x0, y = y0;
            while (x <= max) //Euler's method
            {
                point.X = x;
                point.Y = y;
                result[0].Add(point);
                double localError = Math.Abs(y - exacEquation.getValue(x, x0, y0));
                point.X = x;
                point.Y = localError;
                result[1].Add(point);
                double k1 = orig(x, y);
                double k2 = orig(x + h, y + h * k1);
                y = y + h * (k1 + k2) / 2;
                x = x + h;
            }

            //global error
            for (int i = 0; i < max_er; i++)
            {
                x = x0;
                y = y0;
                h = (max - x0) / (i + 1);
                for (int j = 0; j < i + 1; j++)
                {
                    double k1 = orig(x, y);
                    double k2 = orig(x + h, y + h * k1);
                    y = y + h * (k1 + k2) / 2;
                    x = x + h;
                }
                if (i > 1)
                {
                    double globalError = Math.Abs(y - exacEquation.getValue(x, x0, y0));
                    point.X = i;
                    point.Y = globalError;
                    result[2].Add(point);
                }
            }

            return result;
        }
    }
    public class Runge_Kutta : Method
    {
        internal override List<PointD>[] Solve(double x0, double y0, double max, int num, int max_er)
        {
            double h = (max - x0) / num; //step size
            PointD point = new PointD();
            Exact exacEquation = new Exact();

            List<PointD>[] result = new List<PointD>[3]; //creating a list 
            result[0] = new List<PointD>(); // List for points of Euler's method grapgh
            result[1] = new List<PointD>(); // List for local errors of the Euler's method
            result[2] = new List<PointD>(); // List for global error plotting

            double x = x0, y = y0;
            while (x <= max) //Euler's method
            {
                point.X = x;
                point.Y = y;
                result[0].Add(point);
                double localError = Math.Abs(y - exacEquation.getValue(x, x0, y0));
                point.X = x;
                point.Y = localError;
                result[1].Add(point);
                double k1 = orig(x, y);
                double k2 = orig(x + h / 2, y + h * k1 / 2);
                double k3 = orig(x + h / 2, y + h * k2 / 2);
                double k4 = orig(x + h, y + h * k3);
                y = y + h * (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                x = x + h;
            }

            //global error
            for(int i = 0; i < max_er; i++)
            {
                x = x0;
                y = y0;
                h = (max - x0) / (i + 1);
                for(int j = 0; j < i + 1; j++)
                {
                    double k1 = orig(x, y);
                    double k2 = orig(x + h / 2, y + h * k1 / 2);
                    double k3 = orig(x + h / 2, y + h * k2 / 2);
                    double k4 = orig(x + h, y + h * k3);
                    y = y + h * (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                    x = x + h;
                }
                if (i > 1)
                {
                    double globalError = Math.Abs(y - exacEquation.getValue(x, x0, y0));
                    point.X = i;
                    point.Y = globalError;
                    result[2].Add(point);
                }
            }

            return result;
        }
    }
}
