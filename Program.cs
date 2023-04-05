class Program {

    static void Main() {

        //Implicit casting
        ////sbyte
        ////sbyte a = 10;

        ////char
        //char a = 'A';

        ////int
        //int b;

        ////copy the value from a to b using implicit casting
        //b = a;

        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Console.ReadKey();
        //--------------------------------------------------------------
        //Explicit Casting
        //int
        int a = 500;

        //byte
        byte b;

        //copy the value of a to b with explicit casting
        //int to byte loosy conversion a = 500, b = 244;
        b = (byte)a;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.ReadKey();
        //------------------------------------------------------------------
        //Parsing


    }

}