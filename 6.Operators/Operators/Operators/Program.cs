using Operators;

internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        var arithmeticOperators = new Arithmetic_Operators();
        //arithmeticOperators.ArithmeticOperatorsWithVaeriale();
        //arithmeticOperators.ArithmeticOperatorsWithValues();

        var assignmentOperators =new Assignment_Operators();
        //assignmentOperators.AssignmentOperators();

        var relationalOperators = new Relational_Operators();
        //relationalOperators.RelationalOperators();

        var logicalOperators = new Logical_Operators();
        //logicalOperators.LogicalOperators();

        var bitwiseOperators = new Bitwise_Operators();
        //bitwiseOperators.BitwiseOperators();
        //bitwiseOperators.BitwiseOperatorsBool();

        var ternaryOperator = new Ternary_Operator();
        ternaryOperator.TernaryOperator();
    }
}