using System;
using System.Linq;


namespace ConsoleApplication1
{
    class  Program
    {
        static void Main(string[] args)
        {
            

        }
        public static IEnumerable<int> BaumSweet()
        {
            for (int a = 0; a < 1000000; ++a)
                yield return Check(a) ? 1 : 0;

            static bool Check(int a)
            {
                while (a != 0)
                {
                    if ((a & 1) == 1)
                        a >>= 1;
                    else
                    {
                        if ((a & 3) == 0)
                            a >>= 2;
                        else
                            return false;
                    }
                }
                return true;
            }
        }

    }

}