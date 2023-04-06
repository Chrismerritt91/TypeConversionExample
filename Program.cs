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
        //int a = 500;

        ////byte
        //byte b;

        ////copy the value of a to b with explicit casting
        ////int to byte loosy conversion a = 500, b = 244;
        //b = (byte)a;

        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Console.ReadKey();
        //------------------------------------------------------------------
        //Parsing
        //string
        //string a = "100";

        ////int
        //int b;

        ////string to int
        //b = int.Parse(a);

        //Console.WriteLine(a);//100 in string form
        //Console.WriteLine(b);//100 in numerical form
        //Console.ReadKey();
        //-------------------------------------------------------------------
        //TryParse
        //string
        //string s;
        //Console.WriteLine("Please enter a number:");
        //s = Console.ReadLine();

        ////TryParse
        //bool b = int.TryParse(s, out int n);

        //if(b == true) {
        //    Console.WriteLine("Conversion Successful");
        //    Console.WriteLine(n);
        //}
        //else {
        //    Console.WriteLine("Conversion Unsuccessful");

        //}
        //Console.ReadKey();
        //-------------------------------------------------------------------
        //Conversion Methods
        //int
        //int a = 1000;

        ////string
        //string b;

        ////int --> string
        //b = System.Convert.ToString(a);

        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Console.ReadKey();
        //----------------------------------------------------------------------
        //section 7 assignment

        byte a = 10; //Convert this value into "short" type (assign into another short type of variable)
        short sa = a;

        int b = 10; //Convert this value into "short" type (assign into another short type of variable)
        short sb = (short)b;

        string c = "10.34"; //Convert this value into "double" type using Parse  //Also, convert the same value into "decimal" type  using TryParse
        double pc = double.Parse(c);

        bool tpc = decimal.TryParse(c, out decimal tpd);
        if(tpc == true) {
            Console.WriteLine("Conversion Successful");
        }
        else {
            Console.WriteLine("Conversion Failed");
        }

        decimal d = 11.56M; //Convert this value into "string" type (assign into another string type of variable)
        string sd = System.Convert.ToString(d);

        Console.WriteLine(sa);
        Console.WriteLine(sb);
        Console.WriteLine(pc);
        Console.WriteLine(tpd);
        Console.WriteLine(sd);
        Console.ReadLine();

    }

}