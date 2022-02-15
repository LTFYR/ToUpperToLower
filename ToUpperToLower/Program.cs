using System;

namespace ToUpperToLower
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Console.Write("Metndeki boyuk herfler kicik,kicik herfler boyuk olacaq \n ");
            Console.Write("Metni daxil edin : ");
            string str = Console.ReadLine();
            char[] chArr = str.ToCharArray();

            Console.Write("\nYeni metniniz bu sekilde olacaq : \n");
            for (int i = 0; i < chArr.Length; i++)
            {
                if (char.IsUpper(chArr[i]))
                {
                    chArr[i] = char.ToLower(chArr[i]);
                }

                else
                    chArr[i] = char.ToUpper(chArr[i]);

            }
            Console.WriteLine(string.Join("", chArr));
        }



          
                
            
        }
    
}