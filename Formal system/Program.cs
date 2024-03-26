using System;

namespace Formal_system
{
    class Program
    {
        static char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };


        static bool isFormula(string str)
        {
            if(str == ".")
            {
                return true;
            }

            if(str.Length >= 2)
            {
                if (str[0] == '(' && isFormula(str.Trim(new char[] { str[0], str[str.Length - 1] })) && str[str.Length - 1] == ')')
                {
                    return true;
                }

            }

            return false;
        }

        static bool isAxiom(string str)
        {
            return true;
        }

        static string FirstRool(string formula)
        {
            if (isFormula(formula))
            {
                return "(" + formula + ")";
            }
            else return "NaN";
        }

        // . -> 1
        static string SecondRool(string formula, int index)
        {
            if (isFormula(formula))
            {
                return formula.Replace(".", $"{symbols[index]}");
            }
            else return "NaN";
        }


        static void Main(string[] args)
        {
            string start = ".";

            start = FirstRool(start);

            //Console.WriteLine(isFormula(""));
            //Console.WriteLine(isFormula("."));
            //Console.WriteLine(isFormula("((.))"));

            Console.WriteLine(start);

            start = SecondRool(start, 2);

            Console.WriteLine(start);

        }
    }
}
