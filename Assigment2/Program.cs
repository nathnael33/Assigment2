using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assigment2
{
    internal class Program
    {
        static void Main(string[] args)
        {


        
            
            {


                string s;
                Console.Write(" Please Enter  A Word: ");
                s = Console.ReadLine();
                int len = s.Length;
                int vowel = 0;
               int con = 0;
              

                for (int i = 0; i < len; i++)
                {

                    if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                    {
                        vowel++;
                    }
                    else  
                    {
                        con++;
                    }
                }
               
                Console.WriteLine("The total number of vowel in the string is :"+vowel);
                Console.Write("The total number of consonant in the string is :"+con);
                Console.ReadKey();
            }
        }



    }
    }

