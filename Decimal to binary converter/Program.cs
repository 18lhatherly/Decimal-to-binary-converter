using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_to_binary_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string selectedOption;
            bool stillPlaying = true;
            string userInput;
            bool valid = false;
            

            do
            {
                valid = false;
                Console.WriteLine("Please select an option below for what you would like to convert.");
                Console.WriteLine("A - denary to binary");
                Console.WriteLine("B - binary to denary");

                selectedOption = Console.ReadLine();
                if (selectedOption.ToLower() == "a")
                {
                    denaryToBinary();
                }
                else if (selectedOption.ToLower() == "b")
                {
                    binaryToDenary();
                }
                else
                {
                    Console.WriteLine("Input is invalid.");
                }
                
                while (valid == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Would you like to try again?");
                    userInput = Console.ReadLine();
                    if (userInput.ToLower() == "yes" || userInput.ToLower() == "y")
                    {
                        stillPlaying = true;
                        valid = true;
                    }
                    else if (userInput.ToLower() == "no" || userInput.ToLower() == "n")
                    {
                        stillPlaying = false;
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }
                    //Console.WriteLine(stillPlaying);
                }
                //Console.WriteLine(stillPlaying);

            } while (stillPlaying == true);

            Console.WriteLine("Have a nice day.");

            Console.ReadLine();
        }
        static void denaryToBinary()
        {
            int denary = 0;
            Stack<string> binary = new Stack<string>();


            Console.Write("Please enter denary number: ");
            denary = Convert.ToInt32(Console.ReadLine());

            while (denary > 0)
            {
                if (denary % 2 == 0)
                {
                    binary.Push("0");
                }
                else
                {
                    binary.Push("1");
                }
                denary = denary / 2;
            }
            foreach (string str in binary)
            {
                Console.Write(str);
            }
        }
        static void binaryToDenary()
        {
            string binary;
            int exponent;
            double denary = 0;
            Console.Write("Please enter binary number: ");
            binary = (Console.ReadLine());
            exponent = binary.Length - 1;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    //Console.WriteLine(Math.Pow(2, exponent));
                    denary += Math.Pow(2,exponent);
                }
                exponent = exponent - 1;
            }
            Console.WriteLine(denary);
        }
    }
}
