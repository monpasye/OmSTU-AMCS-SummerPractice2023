namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        double[] Answer = new double [2];
        double d;
        d=(b*b)-4*(a*c);
        double epsilon=1e-9;

        if (Math.Abs(a)<epsilon)
        {
            throw new System.ArgumentException();
        }
        if (Double.IsNaN(a) || Double.IsNegativeInfinity(a) || Double.IsInfinity(a) || Double.IsNaN(b) || Double.IsNegativeInfinity(b) || Double.IsInfinity(b)
        || Double.IsNaN(c) || Double.IsNegativeInfinity(c) || Double.IsInfinity(c))
        {
            throw new ArgumentException();
        }

        if (d<-epsilon)
        {
            Answer=new double[0];
            return Answer;
        }
        else if (-epsilon<d && d<0)
        {
            Answer=new double [1];
            Answer[0]=(-b+Math.Sqrt(d))/(2*a);
            return Answer;
        }
        else
        {
            Answer[0]=(-b-Math.Sqrt(d))/(2*a);
            Answer[1]=(-b+Math.Sqrt(d))/(2*a);
            return Answer;
        }
    }
}
