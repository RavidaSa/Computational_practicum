using System;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO: Create abstract class method
// TODO: Make the inheritance 
// TODO: locate corresponding functions
// TODO: Create exact solution method

public class DE_Solution
{

    public DE_Solution() { }
    
    public double orig(double x, double y) { 
        return (Math.Exp(y) - 2/(x));
    }

    public double exact(double x, double x0, double y0) { //TODO:Write the exact funct
        double y;
        return y;
    }

    public double constant(double x0, double y0) { //TODO: write formula to compute constant for particular solution
        double c;
        return c;
    }

    public List<Point>[] euler_method(double x0, double y0, double max, int num, int max_err) {
        double h = (max - x0)/num; //step size
        Point point = new Point();

        List<Point>[] result = new List<Point>[3]; //creating a list 
        result[0] = new List<int>(); // List for points of Euler's method grapgh
        result[1] = new List<int>(); // List for local errors of the Euler's method
        result[2] = new List<int>(); // List for global error plotting

        double x = x0, y = y0; 
        while (x <= max) //Euler's method
        {
            point.X = x;
            point.Y = y;
            result[0].Add(point);
            y = y + h * orig(x, y);
            x = x + h;
        }

        return result;
    }
}
abstract class Method {
    public abstract List<Point>[] Solve(double x0, double y0, double max, int num, int max_er) { }
}
public class Exact {
    public List<Point> Solve(double x0, double y0, double max, int num) {
        List<Point> result = new List<Point>();
        double h = (max - x0) / num; //step size
        double c = find_c(x0, y0);
        Point point;
        while (x0<max) {
            point.X = x0;
            point.Y = 1 / (1-c*x0);
            result.Add(point);
            x0 += h;
        }

    }
    
    private static double find_c(double x0, double y0) {
        return (y0 - 1) / (y0*x0);
    }
}
public class Euler:Method {
    public override List<Point>[] Solve(double x0, double y0, double max, int num, int max_er)
    {
        throw new NotImplementedException();
    }
}
public class Euler_ex:Method {
    public override List<Point>[] Solve(double x0, double y0, double max, int num, int max_er)
    {
        throw new NotImplementedException();
    }
}
public class Runge_Kutta:Method {
    public override List<Point>[] Solve(double x0, double y0, double max, int num, int max_er)
    {
        throw new NotImplementedException();
    }
}