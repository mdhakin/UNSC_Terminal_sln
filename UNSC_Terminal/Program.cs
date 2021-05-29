using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace UNSC_Terminal
{
    class Program
    {
       static string inputString = @"UNSC.txt";
        static List<string> lines = File.ReadAllLines(inputString).ToList();

        static void Main(string[] args)
        {
            int ct = 10000;
            
            for (int i = 0;i< ct; i++)
            {
                loopMessage();
                System.Threading.Thread.Sleep(5000);
                Console.Clear();
            }
            

            string r = Console.ReadLine();

        }

     
        private static void loopMessage()
        {
      
            writeLineCode("");

            

            Console.WriteLine();
            Console.WriteLine();



        }


        private static void writeLineCode(string lineCode)
        {
            string str;
            
         
            foreach (string item in lines)
            {

                str = item.ToString();

                for (int j = 0;j < str.Length;j++)
                {
                   writeSection(str[j].ToString());
                }
                
                newline();
            }

            Console.Clear();
        }

        private static void writeSection(string input)
        {

            Console.Write(input);
            System.Threading.Thread.Sleep(20);
        }

        private static void newline()
        {
            Console.WriteLine(" ");
        }
    }
}
