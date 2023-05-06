using System;
using System.Text;

namespace TesteVagaDev
{
    public class Program
    {
        static void Main(String[] args)
        {
            string reverter = "Target Sistemas";
            StringBuilder sb = new StringBuilder();           
            for(var i = reverter.Length-1; i>=0; i--)
            {
                sb.Append(reverter[i]);
            }
                Console.WriteLine(sb.ToString());
        }
    }
}