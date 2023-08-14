using Variables;

internal class Program
{

    static int x = 100; //Static Variable
    int y = 200; //Non-Static or Instance Variable

    public Program(int a)
    {
        y = a;
        x = a;
    }
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        //var staticVariable = new Static_Variable();
        //staticVariable.StaticVariable();

        //Console.WriteLine($"x value: {x}");
        ////Console.WriteLine($"x value: {y}");// Shown Error "an object reference is required for the non-static field, method, or property ‘Program.y"’


        ////  creating an instance of the Program class, and using that instance we are accessing the y variable. But we are accessing directly the x variable
        //var obj = new Program();
        //Console.WriteLine($"y value: {obj.y}");
        //Console.Read();




        ///////Create index 2 times
        ///

        //Console.WriteLine($"x value: {x}");
        //Program obj1 = new Program();
        //Program obj2 = new Program();
        //Console.WriteLine($"obj1 y value: {obj1.y}");
        //Console.WriteLine($"obj2 y value: {obj2.y}");
        //Console.Read();


        /*Console.WriteLine($"x value: {x}");
        Program obj1 = new Program(300);
        Program obj2 = new Program(400);
        Console.WriteLine($"obj1 y value: {obj1.y}");
        Console.WriteLine($"obj2 y value: {obj2.y}");
        Console.Read();*/

        Console.WriteLine($"x value: {x}"); //x = 100


        Program obj1 = new Program(300);
        Console.WriteLine($"obj1 y value: {obj1.y}");// y = 300
        Console.WriteLine($"x value: {x}"); //x = 300


        Program obj2 = new Program(400);
        Console.WriteLine($"obj2 y value: {obj2.y}"); //y =400
        Console.WriteLine($"x value: {x}"); //x = 400
        Console.Read();



    }
}