using Switch;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        int x = 7;

        switch (x)
        {
            case 1:
                Console.WriteLine("Choice is 1");
                break;

            case 2:
                Console.WriteLine("Choice is 2");
                break;
            case 3:
                Console.WriteLine("Choice is 3");
                break;
            default:
                Console.WriteLine("Choice other than 1, 2 and 3");
                break;


        }

        Console.ReadKey();



        var switch_multiple_case = new Multiple_Cases();

        // switch_multiple_case.Switch_multiple_case();

        var nestedSwitch = new NestedSwitch();
        //nestedSwitch.Nested_Switch();

        var Switch_With_If = new switchWithIf();
        Switch_With_If.switch_With_If();
    }
}