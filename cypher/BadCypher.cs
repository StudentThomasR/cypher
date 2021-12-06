using System;
using System.Collections.Generic;
namespace cypher
{
     static class BadCypher //3.This is the class declaration which declares the class and gives it a name. This one is declared static which means you dont have to initialize it in the main program.
    {
      public  static string Encrypt(string input) //4.This is a class member function which is called 'Encrypt'. It is also declared static. As the class is static, all the member functions have to be declared static as well . 
       //5.This member function is also declared public. This means that this member function can be used outside it's native class. This means that I can use it in my main program file. 
        {
            List < char > charlist = new List<char>();
            List<byte> asciilist = new List<byte>(); // I decided to use ascii to shift the letters, however the other way that I could have gone about this is to create a list with the alphabet in, itterate through that list. Then swap the values. This way was alot easier and learnt how to use ascii instead of just writing about it.  
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
        public static string Decrypt(string input)
        {
            List<char> charlist = new List<char>();
            List<byte> asciilist = new List<byte>();
            string outputstring = "";
            foreach (char character in input)
            {
                charlist.Add(character);
            }
            char firstchar = charlist[charlist.Count-1];
            charlist.Insert(0,firstchar);
            charlist.RemoveAt(charlist.Count-1);
            charlist.Reverse();
            for (int index = 0; index < charlist.Count; index++)
            {
                if (charlist[index] == 'a')
                {
                    asciilist.Add(122);
                }
                else if (charlist[index] == 'A')
                {
                    asciilist.Add(90);
                }
                else if (charlist[index] == ' ')
                {
                    asciilist.Add(32);
                }
                else
                {
                    asciilist.Add(Convert.ToByte(charlist[index]));
                    asciilist[index] -= Convert.ToByte(1);
                }
            }
            foreach (byte ascii in asciilist)
            {
                outputstring += Convert.ToChar(ascii);
            }
            return outputstring;
        }

    }
}
