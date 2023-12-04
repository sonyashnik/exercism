using System;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        int result;
        try
        {
            switch (operation)
            {
                case "+":
                    result = SimpleOperation.Addition(operand1, operand2);
                    break;
                case "*":
                    result = SimpleOperation.Multiplication(operand1, operand2);
                    break;
                case "/":
                    result = SimpleOperation.Division(operand1, operand2);
                    break;
                case "":
                    throw new ArgumentException("Operation cannot be empty.", nameof(operation));
                case null:
                    throw new ArgumentNullException("Operation cannot be NULL.", nameof(operation));
                default:
                    throw new ArgumentOutOfRangeException("Operation cannot be found.", nameof(operation));

            }
        }
        catch (DivideByZeroException)
        {
            return "Division by zero is not allowed.";
        }
        return $"{operand1} {operation} {operand2} = {result}";
    }
}


