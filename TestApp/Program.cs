using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TestForSkillEvaluation
{
    class test
    {
        public string poFixExp;
        public string Result;
        Stack i = new Stack();
        public void e()
        {
            int a, b, ans;
            for (int j = 0; j < poFixExp.Length; j++)
            {
                String c = poFixExp.Substring(j, 1);
                if (c.Equals("*"))
                {
                    String sa = (String)i.Pop();
                    String sb = (String)i.Pop();
                    a = Convert.ToInt32(sb);
                    b = Convert.ToInt32(sa);
                    ans = a * b;
                    i.Push(ans.ToString());

                }
                else if (c.Equals("/"))
                {
                    String sa = (String)i.Pop();
                    String sb = (String)i.Pop();
                    a = Convert.ToInt32(sb);
                    b = Convert.ToInt32(sa);
                    ans = a / b;
                    i.Push(ans.ToString());
                }
                else if (c.Equals("+"))
                {
                    String sa = (String)i.Pop();
                    String sb = (String)i.Pop();
                    a = Convert.ToInt32(sb);
                    b = Convert.ToInt32(sa);
                    ans = a + b;
                    i.Push(ans.ToString());

                }
                else if (c.Equals("-"))
                {
                    String sa = (String)i.Pop();
                    String sb = (String)i.Pop();
                    a = Convert.ToInt32(sb);
                    b = Convert.ToInt32(sa);
                    ans = a - b;
                    i.Push(ans.ToString());

                }
                else
                {
                    i.Push(poFixExp.Substring(j, 1));
                }
            }
            Result = (String)i.Pop();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            test e1 = new test();
            Console.WriteLine("Enter any Postfix Expression");
            e1.poFixExp = Console.ReadLine();
            e1.e();
            Console.WriteLine("\n\tPostfix Evaluation:  " + e1.Result);
            Console.ReadKey();
        }
    }
}