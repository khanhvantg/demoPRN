using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoRPN
{
    public class Token
    {
        public static string AddWhiteSpace(string str)
        {
            char[] b= new char[7];
            int k = 0;
            int i = 0;
            int j = str.Length;
            while (i < j)       //Vi du: 2++++-4 <=> 2-4 
            {
                str = str.Replace("++", "+");
                str = str.Replace("-+", "-");
                str = str.Replace("+-", "-");
                str = str.Replace("--", "+");
                j -= 4;
            }
            foreach (char s in str) //chen phia truoc va phi sau toan tu 1 khoang trang.
            {
                int check = 0;
                if (s == '+' || s == '-' || s == '*' || s == '/' || s == '(' || s == ')' || s == '^')
                {
                    for (j = 0; j < k + 1; j++)
                    {
                        if (k == 0) { break; }
                        else if (b[j] == s) { check = 1; break; }
                    }
                    if (check == 0)
                    {
                        string a = char.ToString(s);
                        str = str.Replace(a, " " + a + " ");
                        b[k] = s;
                        k++;
                    }
                }
            }
            str = str.Replace("  ", " ");// +( khi chen khoang trang:  '1 space'+'2 space'('1 space'   
                                         //=>  '1 space'+'1 space'('1 space'
            str = str.Trim(); //xoa nhung khoang trang dau va cuoi chuoi
            return str;
        }
        public static int GetPriority(string token)
        {
            if ((token == "sin") || (token == "cos") || (token == "tan") || 
                (token == "cotan") || (token == "sqrt") || (token == "^"))
                return 4;
            if ((token == "minus") || (token == "plus"))
                return 3;
            if ((token == "*") || (token == "/"))
                return 2;
            if ((token == "+") || (token == "-"))
                return 1;
            return 0;
        }
        public static bool IsLetter(string token)
        {
            if (token.Length == 1 && !IsNumber(token) & !IsOperator(token))
                return true;
            else return false;
        }
        public static bool IsNumber(string token)
        {
            foreach (char s in token)
                if ((s != '.' && (s > 57)) || (s != '.' && (s < 48)))
                    return false;
            return true;
        }
        public static bool IsOperator(string token)
        {
            if ((token == "+") || (token == "-") || (token == "*") || (token == "/") || token == "^")
                return true;
            else return false;
        }
        public static bool IsFunc(string token)
        {
            if ((token == "sin") || (token == "cos") || (token == "tan") || (token == "cotan")
                || (token == "sqrt") || (token == "minus") || (token == "plus"))
                return true;
            else return false;
        }
    }
}
