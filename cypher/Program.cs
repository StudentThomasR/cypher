/*
 * 1.  This code uses classes to perform functions. Most of the comments will be in the class file. 
 */
using System;
using System.Diagnostics;
namespace cypher
{
    class Program
    {
        static void Main(string[] args)
        {
            new CypherProgram(); 
        }
    }
    class CypherProgram
    {
        public CypherProgram() //2.This is the constructor for the cypher program class which is used to create attributes or run functions.

        {
            testsuite();
        }
        void testsuite()
        {
            {
                Console.WriteLine(BadCypher.Encrypt("hello")); //6. This is the Encrypt function being used because I declared the class and functions as static, to access this function you put the class name then a fullstop and then the function name.
                Debug.Assert(BadCypher.Encrypt("hello") == "mmfip");//7. This is a test line. It will stop the program if the test fails. This is testing the encryption of "hello" which should equal "mmfip".
            }
            {
                Console.WriteLine(BadCypher.Decrypt("mmfip")); // As far as usability is concerned, I've not done very much. This program was really designed to show tests running on the piece of code, rather than to actually make it usable. As far as some things that I could do to improve usability, I could make the program check input from the user in a console or I could redesign it to become a graphical application. In another project included in this submission, I will improve the console-user input as well as the graphical user interface.
                Debug.Assert(BadCypher.Decrypt("mmfip") == "hello");
            }
            {
                Console.WriteLine(BadCypher.Encrypt("hi everyone"));
                Debug.Assert(BadCypher.Encrypt("hi everyone") == "opzsfwf jif");
            }
            {
                Console.WriteLine(BadCypher.Decrypt("opzsfwf jif"));
                Debug.Assert(BadCypher.Decrypt("opzsfwf jif") == "hi everyone");
            }
            {
                Console.WriteLine(BadCypher.Encrypt("zebras"));
                Debug.Assert(BadCypher.Encrypt("zebras") == "bscfat");
            }
            {
                Console.WriteLine(BadCypher.Decrypt("bscfat"));
                Debug.Assert(BadCypher.Decrypt("bscfat") == "zebras");
            }

        }

    }
}
