using System;

namespace TesteVagaDev
{
    public class Program
    {
        static void Main(String[] args)
        {
            float sp = 67836.43f;
            float rj = 36678.66f;
            float mg = 29229.88f;
            float es = 27165.48f;
            float outros = 19849.53f;
            float total = sp + rj + mg + es + outros;

            Console.WriteLine(total);

            float percentSp = ((sp/total)*100);
            float percentRj = ((rj/total)*100);
            float percentMg = ((mg/total)*100);
            float percentEs = ((es/total)*100);
            float percentOutros = ((outros/total)*100);

            Console.WriteLine($"O percentual de cada estado foi: {percentSp}, {percentRj}, {percentMg}, {percentEs}, {percentOutros}");

        }
    }
}