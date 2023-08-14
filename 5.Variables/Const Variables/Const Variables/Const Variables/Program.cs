internal class Program
{

    const float PI = 3.14f;
    static int x = 100;

    int y;

    public Program(int a)
    {
        y = a;    
    }
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        Console.WriteLine($"x value: {x}");
        Console.WriteLine($"PI value: {PI}");

        Program obj1 = new Program(300);
        Program obj2 = new Program(400);


        Console.WriteLine($"obj1 y value: {obj1.y}");
        Console.WriteLine($"obj2 y value: {obj2.y}");
        Console.Read();
    }
}