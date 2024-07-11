namespace C42_G02_OOP01
{
    //1. class
    //2. struct
    //3. interface
    //4. enum

    //struct Employee
    //{
    //    int id;
    //    string name;
    //    double salary;
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region demo

            #region Struct ex01
            //struct: ValueType
            //stored in the stack

            //Employee
            //id, namespace, salary

            //point -> x,y
            Point p1; //declaring object/instance of type type "Point "
            //CLR allocates uninitialized 8 bytes at stack

            Console.WriteLine(p1.x); //not valid because the x not initialized
            p1 = new Point();
            //new here is used to select the constructor
            #endregion

            #region  
            #endregion

            #region  
            #endregion

            #region  
            #endregion

            #endregion
        }
    }
}
