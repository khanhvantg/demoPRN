using System;
using System.Windows.Forms;
namespace demoRPN
{
    class Program
    {
        static void Main()
        {
            //string input = Console.ReadLine().Trim();
            //string[] x = new string[26];
            //string[] y = new string[26];
            //int i = 0;
            //while (Token.IsLetter(input))
            //{
            //    x[i] = input;
            //    Console.Write(" = ");
            //    y[i] = Console.ReadLine().Trim();
            //    input = Console.ReadLine().Trim();
            //    i++;
            //}
            //for (int j = 0; j < i; j++)
            //{
            //    if (Token.IsNumber(y[j]))
            //        input = input.Replace(x[j], y[j]);
            //    else input = input.Replace(x[j], "(" + y[j] + ")");
            //}
            //Parser k = new Parser(input);
            //k.LRN(k.InfixToExpessionTree());
            //Console.WriteLine(k.KQ);
            //Console.WriteLine(k.PRN);
            //Console.WriteLine(k.OpS[0]);
            //Console.WriteLine(k.OpS.Count());
            //Console.WriteLine(k.StrOpS[0]);
            //for (int n = 0; n < k.stro; n++)
            //{
            //    Console.WriteLine(k.StrOpS[n]);
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Console.ReadKey();
        }
    }
}