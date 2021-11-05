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
        public CypherProgram()
        {
            testsuite();
        }
        void testsuite()
        {
            {
                Console.WriteLine(BadCypher.Encrypt("hello"));
                Debug.Assert(BadCypher.Encrypt("hello") == "mmfip");
            }
            {
                Console.WriteLine(BadCypher.Decrypt("mmfip"));
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
