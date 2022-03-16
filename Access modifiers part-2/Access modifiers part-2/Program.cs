using System;

namespace Access_modifiers_part_2
{
    internal class Program
    {
        
        static  void Main(string[] args)
        {
            string length = GetInputStr ("Nece insan daxil edirsiniz?", 0);
            bool result;

            string Name = "Nargiz";
            result = Char.IsUpper(Name, 0);
            Console.WriteLine(result);


            string SurName = "Ganiyeva";
            result = Char.IsUpper(SurName, 0);
            Console.WriteLine(result);


            //char SurName = "Qaniyeva";
            //result= Char.IsUpper(SurName);
            //Console.WriteLine(result);



            for (int i = - 1; i >= 0; i--)
            {
                 Name = GetInputStr($"Nargiz ", 3, 30);
                SurName = GetInputStr($"Qaniyeva", 3, 35);


            }
            
            static string GetInputStr(string Name, int min, int max = 35)
            {
                string input;
                if (Name .Length > 30)
                {
                    Console.WriteLine("Ola bilmez");
                }
                else if (Name .Length > 3 )
                {
                    Console.WriteLine("Max-dir");
                }
                else 
                {
                    Console.WriteLine("min-dir");
                }
                
                //do
                //{
                //    Console.WriteLine(Name);
                //    input = Console.ReadLine();
                //} while (input.Length < min || input.Length > max);

                //return input;
            }
        }
    }
}
