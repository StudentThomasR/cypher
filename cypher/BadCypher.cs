using System;
using System.Collections.Generic;
namespace cypher
{
     static class BadCypher
    {
      public  static string Encrypt(string input)
        {
            List < char > charlist = new List<char>();
            List<byte> asciilist = new List<byte>();
            string outputstring = "";
            foreach (char character in input)
            {
                charlist.Add(character);
            }
            charlist.Reverse();
            char firstchar = charlist[0];
            charlist.Add(firstchar);
            charlist.RemoveAt(0);
            for (int index = 0; index < charlist.Count ; index++)
            {
                if (charlist[index] == 'z')
                {
                    asciilist.Add(97);
                }
                else if (charlist[index] == 'Z')
                {
                    asciilist.Add(65);
                }
                else if (charlist[index]==' ')
                {
                    asciilist.Add(32);
                }
                else
                {
                 asciilist.Add(Convert.ToByte(charlist[index]));
                    asciilist[index] += Convert.ToByte(1);
                }
            }
            foreach (byte ascii in asciilist)
            {
                 outputstring +=Convert.ToChar(ascii); 
            }
            return outputstring;
        }
        static string Decrypt(string input)
        {
            List<char> charlist = new List<char>();
            foreach (char character in input)
            {
                charlist.Add(character);
            }
            charlist.Reverse();
            charlist.Insert(0,charlist[charlist.Count]);
            charlist.RemoveAt(charlist.Count);
            return "Error";
        }
    }
}
