using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Method4();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }

        static void Method1()
        {
            Console.WriteLine("Inside Method 1");
            int a = 10;
            int b = 0;
            Console.WriteLine(a / b);
        }

        static void Method2()
        {
            try
            {
                Method1();
            }
            catch (Exception)
            {

                throw;
            }
        }

        static void Method3()
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        static void Method4()
        {
            try
            {
                int a = 101;
                int b = 0;
                Console.WriteLine(a / b);
            }
            catch (Exception)
            {

                throw;
            }
        }

        static void Method5()
        {
            try
            {
                int a = 101;
                int b = 0;
                Console.WriteLine(a / b);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }
    }
}
