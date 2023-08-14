internal class Program
{
    const float PI = 3.14f; 
    static int x = 100; 
                       
    int y; 
    readonly int z;

    public Program(int a, int b)
    {
        y = a;
        z = b;
    }

    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        //Accessing the static variable without instance
        Console.WriteLine($"x value: {x}");
        //Accessing the constant variable without instance
        Console.WriteLine($"PI value: {PI}");
        Program obj1 = new Program(300, 45);
        Program obj2 = new Program(400, 55);
        //Accessing Non-Static variable using instance
        Console.WriteLine($"obj1 y value: {obj1.y} and Readonly z value: {obj1.z}");
        Console.WriteLine($"obj2 y value: {obj2.y} and Readonly z value: {obj2.z}");

        // obj1.z = 500; - Can not assign any value defied readonly 
        // constructor or init-only setter of the type in which the field is defined or a variable initializer
        Console.Read();
    }



    public void NonStaticBlock()
    {
        //By Default, every local variable is going to be non-static
        //The Scope is limited to this method only
        int x = 100;
    }
    public static void StaticBlock()
    {
        //By Default, every local variable is going to be static
        //The Scope is limited to this method only
        int y = 100;
    }
}