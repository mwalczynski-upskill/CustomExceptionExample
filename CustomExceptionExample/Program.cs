using System;

namespace CustomExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw NewCustomException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        public static CustomException NewCustomException()
        {
            var description = "Custom exception description";
            var exception = new CustomException(description);
            return exception;
        }
    }
}
