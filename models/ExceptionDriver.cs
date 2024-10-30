using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2024_10_30_a_exceptions_enums_strings.models
{
    public static class ExceptionDriver
    {
        public static void Run()
        {
            // Console.Write("Exception is Running");
            ArgumentOutOfRangeAndNullExceptionDemo();
            ArgumentNullExceptionDemo();
            IoExceptionDemo();
            InvalidOperationExceptionDemo();
            ArgumentOutOfRangeExceptionDemo();
            FormatExceptionDemo();
            DivideByZeroExceptionDemo();
            IndexOutOfRangeExceptionDemo();
            NullReferenceExceptionDemo();
        }

        //try {

        //}
        //catch(Exception ex) {
        // Console.WriteLine($"DivideByZeroException\t\t caught:\t{ex.Message}");
        //    }

        public static void ArgumentOutOfRangeAndNullExceptionDemo()
        {

            try
            {
                //PrintColour("GreeNx");
                PrintColour(null);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"ArgumentOutOfRangeException\t\t caught:\t{ex.Message}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"ArgumentNullException\t\t caught:\t{ex.Message}");
            }
            finally
            {
                Console.WriteLine("My favourite colour is orange");

            }

        }

        public static void PrintColour(string colour)
        {
            if (colour is null)
            {
                throw new ArgumentNullException(nameof(colour), "Colour cannot be null");
            }

            List<string> validColours = new List<string>() { "red", "green", "orange" };

            if (!validColours.Contains(colour.ToLower()))
            {
                throw new ArgumentOutOfRangeException(nameof(colour), "Colour must be red, green or orange");
            }

            Console.WriteLine($"You chose: {colour.ToUpper()}");

        }

        public static void ArgumentNullExceptionDemo()
        {

            try
            {
                PrintMessage(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"ArgumentNullException\t\t caught:\t{ex.Message}");
            }
        }



        public static void PrintMessage(string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message), "Message cannot be null");
            }
            Console.WriteLine($"The message is: {message}");
        }


        public static void IoExceptionDemo()
        {
            string filePath = "this-file-does-not-exist.txt";


            try
            {
                string content = File.ReadAllText(filePath);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"IoExceptionDemo\t\t caught:\t{ex.Message}");
            }

        }

        public static void InvalidOperationExceptionDemo()
        {
            Queue<int> numbersQueue = new Queue<int>();

            try
            {
                int number = numbersQueue.Dequeue();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"InvalidOperationException\t caught:\t{ex.Message}");
            }

        }


        public static void ArgumentOutOfRangeExceptionDemo()
        {
            List<int> numbers = new List<int>() { 1, 2, 3 };


            try
            {
                Console.WriteLine(numbers[-1]);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"ArgumentOutOfRangeException\t caught:\t{ex.Message}");
            }
        }


        public static void FormatExceptionDemo()
        {
            string invalidNumber = "ABC";
            try
            {
                int result = int.Parse(invalidNumber);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"FormatException\t\t\t caught:\t{ex.Message}");
            }
        }


        public static void DivideByZeroExceptionDemo()
        {
            int dividend = 10;
            int divisor = 0;
            try
            {
                int result = dividend / divisor;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"DivideByZeroException\t\t caught:\t{ex.Message}");
            }

        }

        public static void IndexOutOfRangeExceptionDemo()
        {
            int[] numbers = { 1, 2, 3 }; // position 0, 1, 2

            try
            {
                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"IndexOutOfRangeException\t caught:\t{ex.Message}");
            }
        }

        public static void NullReferenceExceptionDemo()
        {
            //  Console.Write("NullReferenceExceptionDemo");

            string message = null;
            try
            {
                Console.WriteLine(message.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"NullReferenceException\t\t caught:\t{ex.Message}");
            }
            finally
            {
                Console.WriteLine($"NullReferenceException Demonstration has finished");
            }

        }
    }
}
