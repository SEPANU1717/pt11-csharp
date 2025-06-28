namespace FrmCalculator;

public partial class Form1 : Form
{
    private CalculatorClass cal;
    
    public Form1()
    {
        InitializeComponent();
        string [] operators = { "+", "-", "*", "/" };
        foreach(var op in operators)
            cbOperator.Items.Add(op);
        
        cal = new CalculatorClass();
    }

    private void btnEqual_Click(object sender, EventArgs e)
    {
        double num1 = double.Parse(txtBoxInput1.Text);
        double num2 = double.Parse(txtBoxInput2.Text);
        string op = cbOperator.SelectedItem.ToString();
        
        CalculatorClass calcevent = new CalculatorClass();
        if (op == "+")
        {
            calcevent.CalculateEvents += new CalculateEvent(calcevent.GetSum);
            lblDisplayTotal.Text = calcevent.GetSum(num1, num2).ToString();
            calcevent.CalculateEvents -= new CalculateEvent(calcevent.GetSum);
        }
        
        else if (op == "-")
        {
            calcevent.CalculateEvents += new CalculateEvent(calcevent.GetDifference);
            lblDisplayTotal.Text = calcevent.GetDifference(num1, num2).ToString();
            calcevent.CalculateEvents -= new CalculateEvent(calcevent.GetDifference);
        }
        else if (op == "*")
        {
            calcevent.CalculateEvents += new CalculateEvent(calcevent.GetProduct);
            lblDisplayTotal.Text = calcevent.GetProduct(num1, num2).ToString();
            calcevent.CalculateEvents -= new CalculateEvent(calcevent.GetProduct);
        }
        
        else if(op == "/")
        {
            calcevent.CalculateEvents += new CalculateEvent(calcevent.GetQuotient);
            lblDisplayTotal.Text = calcevent.GetQuotient(num1, num2).ToString();
            calcevent.CalculateEvents -= new CalculateEvent(calcevent.GetQuotient);
        }
    }
}