using System;

using System.Text;

using System.IO;

using System.Text.RegularExpressions;

namespace BaiduTest
{



    public class CStrOne
    {

        protected string m_str1 = string.Empty;

        public CStrOne(string str1)
        {

            this.m_str1 = str1;

        }

        public void ShowStringOne()
        {

            Console.WriteLine(m_str1);

        }

    }

    // 继承CStrOne

    public class CStrTwo : CStrOne
    {

        private string m_str2 = string.Empty;

        public CStrTwo(string str, string str2)
            : base(str)
        {

            this.m_str2 = str2;

        }

        public void ShowStringTwo()
        {

            Console.WriteLine("{0}{1}", m_str1, m_str2);

        }

    }

    class Program
    {

        static void Main(string[] args)
        {

            CStrOne cs1 = new CStrOne("ni ");

            cs1.ShowStringOne();

            CStrTwo cs2 = new CStrTwo("你 ", "和我.");

            cs2.ShowStringTwo();



            Console.ReadKey();

        }

    }

}