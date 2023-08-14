using Type_Casting;

internal class Program
{
    private static void Main(string[] args)
    {
       // Console.WriteLine("Hello, World!");

        var implicitTypeCasting = new Implicit_Type_Casting();

        //implicitTypeCasting.ImplicitTypeCasting();

        var helperMethod = new Conversion_with_Helper_method();

        //helperMethod.HelperMethod2();
        //helperMethod.HelperMethod1();

        var castingDataLoss = new Casting_Data_Loss();
        //castingDataLoss.CastingDataLoss();

        var explicit_Type_Casting = new Explicit_Type_Casting();
       //explicit_Type_Casting.ExplicitTypeCasting();

        var implicit_Type_Casting = new Implicit_Type_Casting();
        //explicit_Type_Casting.ExplicitTypeCasting();

        var tryPassMethod = new TryPassMethod();
        tryPassMethod.TryPass();

    }
}