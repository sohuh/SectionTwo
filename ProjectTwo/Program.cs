using System;
using System.Numerics;
using System.Security;
namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables and Constants Demo 
            
            // Var datatype allows C# itself to assume and figure out what each data type is based off what value is being stored within it.
            // Bytes have to be specially intialized as C# auto-assumes that number values are integers 
            var number = 2;
            // The added f makes it so that C# knows its a float value 
            var totalPrice = 20.95f;
            var character = 'A';
            // 0 represents the first value after the given string, 1 represents the second value after the given string
            System.Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            System.Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            
            // Must be initialized like this
            const float Pi = 3.14f;

            // Type Conversion Demo
            
            // This does work all the way up to 255
            int i = 1;
            byte b = (byte) i;
            System.Console.WriteLine(b);

            try
            {
                string str = "true";
                bool btwo = Convert.ToBoolean(str);
                Console.WriteLine(btwo);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }


            // Operators Demo
            
            
            var atwo = 1;
            var bthree = 2;
            var c = 3;
            Console.WriteLine(!(c > bthree || c == atwo));



        }
    }
}