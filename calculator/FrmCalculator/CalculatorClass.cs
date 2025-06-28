namespace FrmCalculator;

public delegate double CalculateEvent(double arg1, double arg2);
public  delegate T Formula<T>(T arg1);
public class CalculatorClass
{
    Formula<double> formula;
    public CalculateEvent CalcEvent;
    public event CalculateEvent CalculateEvents
    {
        add
        {
            Console.WriteLine("Event added");
            CalcEvent += value;
        }
        remove
        {
            Console.WriteLine("Event removed");
            CalcEvent -= value;
        }
    }
    
    public double GetSum(double arg1, double arg2) => arg1 + arg2;
    public double GetDifference(double arg1, double arg2) => arg1 - arg2;
    public double GetProduct(double arg1, double arg2) => arg1 * arg2;
    public double GetQuotient(double arg1, double arg2) => arg1 / arg2;
    
    
        
}