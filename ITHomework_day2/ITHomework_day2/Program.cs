using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHomework_day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion

            int a = 15;
            double b = a;

            decimal c = 42;
            long d = 12;
            c = c - d;

            short e = 64;
            short f = 36;
            float g = e + f;

            //explicit conversion

            int h;
            double i = 15.2f;
            h = (int)i;

            //next one working without casting but produces reduced result

            int j=76;
            int k=38;
            float l = (float)j / k;

            char m = 'M';
            string mString = m.ToString();

            //boxing/unboxing

            string magicBoxing = "I am a magic box!";
            object magicShelve = magicBoxing;
           
            string magicUnboxing = (string)magicShelve;

            //simple language types

            sbyte A =1;
            SByte A1= 2;
            Console.WriteLine(A.GetType());
            Console.WriteLine(A1.GetType());

            short B=3;
            Int16 B1=4;
            Console.WriteLine(B.GetType());
            Console.WriteLine(B1.GetType());

            int C=5;
            Int32 C1=6;
            Console.WriteLine(C.GetType());
            Console.WriteLine(C1.GetType());

            long D=7;
            Int64 D1=8;
            Console.WriteLine(D.GetType());
            Console.WriteLine(D1.GetType());

            byte E=9;
            Byte E1=10;
            Console.WriteLine(E.GetType());
            Console.WriteLine(E1.GetType());

            ushort F=11;
            UInt16 F1=12;
            Console.WriteLine(F.GetType());
            Console.WriteLine(F1.GetType());

            char G='a';
            Char G1='b';
            Console.WriteLine(G.GetType());
            Console.WriteLine(G1.GetType());

            uint H=13;
            UInt32 H1=14;
            Console.WriteLine(H.GetType());
            Console.WriteLine(H1.GetType());

            ulong I=15;
            UInt64 I1=16;
            Console.WriteLine(I.GetType());
            Console.WriteLine(I1.GetType());

            float J=17;
            Single J1=18;
            Console.WriteLine(J.GetType());
            Console.WriteLine(J1.GetType());

            double K=19;
            Double K1=20;
            Console.WriteLine(K.GetType());
            Console.WriteLine(K1.GetType());

            decimal L=21;
            Decimal L1=22;
            Console.WriteLine(L.GetType());
            Console.WriteLine(L1.GetType());

            string M="Denis";
            String M1="Dusmikeev";
            Console.WriteLine(M.GetType());
            Console.WriteLine(M1.GetType());

            //object type is defined at runtime

            object N =L;
            Object N1 =L1;
            Console.WriteLine(N.GetType());
            Console.WriteLine(N1.GetType());

            Console.ReadLine();

        }
    }
}
