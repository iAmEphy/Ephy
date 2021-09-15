using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ephy
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello World!");

            Console.WriteLine(" |--|");
            Console.WriteLine(" |  |");
            Console.WriteLine(" |  |");
            Console.WriteLine(" |__|");
            Console.WriteLine("What's your name?");
            string input = Console.ReadLine();

            

            if(input == "Tony")
            {
                Console.WriteLine("Ha loser");
            }
            else
            {
                Console.WriteLine("Oh hey, nice to meet you " + input);
            }


            Console.WriteLine("How old are you?");

            int age = Console.Read();

            if (age >= 21)
            {
                Console.WriteLine("Wow you are old!");
            }
            else
            {
                Console.WriteLine("Wow you are very young!");

            }

            for(int i = 0; i < input.Length; i++)
            {
                char character = input[i];
                //Comment

                Console.WriteLine(input[i]);
            }




            bool isMale = true;

            //Console.WriteLine("Text\nNewLine");

            //Literal string. \"

            Console.WriteLine("To upper method");
            // ToLower() is to lowercase
            Console.WriteLine(input.ToUpper());


            //Contains can be single or double quote 'o' "o"
            if (input.Contains("o"))
            {
                Console.WriteLine(input.Contains("o"));
            }

            //When does L chracter pop up
            Console.WriteLine(input.IndexOf("L"));

            //grabs character starting at whichever number 
            Console.WriteLine(input.Substring(5));


            //From beginning to fourth letter
            Console.WriteLine(input.Substring(0,4));


            //Absolute value
            Console.WriteLine(Math.Abs(-10));


            //Same as java i++ increment


            // 3 ^ 2
            Console.WriteLine(Math.Pow(3, 2));

            Math.Sqrt(36);

            //Which number is bigger
            Math.Max(10, 20);


            //convert to number
            int conversion = Convert.ToInt32("123");

            Console.WriteLine(conversion + 2);
            //125


            Console.WriteLine("Enter a whole number: ");
            //convert toint32 is whole number. Convert.ToDouble accepts decimalss
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1);






        }
    }
}
