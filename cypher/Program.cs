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
                Debug.Assert(BadCypher.Encrypt("hello")=="mmfip");  
            }
        }
    }
  
}
