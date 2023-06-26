namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        double[] Result = new double [2];
        double d;
        d=(b*b)-4*(a*c);
        double epsilon=1e-9;

        if (a=0)
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
            Result=new double[0];
            return Result;
        }
        else if (Math.Abs(d)<epsilon)
        {
            Result=new double [1];
            Result[0]=(-b+Math.Sqrt(d))/(2*a);
            return Result;
        }
        else
        {
            Result[0]=(-b-Math.Sqrt(d))/(2*a);
            Result[1]=(-b+Math.Sqrt(d))/(2*a);
            return Result;
        }
    }
}
