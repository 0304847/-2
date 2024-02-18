using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практическая__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double G1, f1, y1;

            Console.WriteLine("задача №1");
            Console.WriteLine("введите значение f");
            f1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите занчение y");
            y1 = Convert.ToDouble(Console.ReadLine());

            G1 = (Math.Exp(2 * y1) + Math.Sin(f1)) / (Math.Log(3.8 * y1 + f1));
            Console.WriteLine($"решение задачи №1={G1}");

            double F2, d2, y2;

            Console.WriteLine("задача №2");
            Console.WriteLine("введите занчение d");
            d2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите y");
            y2 = Convert.ToDouble(Console.ReadLine());

            F2 = Math.Log(d2) + (3.5 * d2 + 1) / (Math.Cos(2 * y2));
            Console.WriteLine($"решене задания №2={F2}");

            double U3, k3, y3;

            Console.WriteLine("задача №3");
            Console.WriteLine("введите значение k");
            k3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y3 = Convert.ToDouble(Console.ReadLine());

            U3 = (Math.Log(k3 - y3) + Math.Pow(y3, 4)) / (Math.Exp(y3) + 2.355 * Math.Pow(k3, 2));
            Console.WriteLine($"решение задачи №3={U3}");

            double G4, w4, y4;

            Console.WriteLine("задача №4");
            Console.WriteLine("введите значение w");
            w4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y4 = Convert.ToDouble(Console.ReadLine());

            G4 = (9.33 * Math.Pow(w4, 3) + Math.Sqrt(w4)) / (Math.Log(y4 + 3.5) + Math.Sqrt(y4));
            Console.WriteLine($"решение задачи №4={G4}");

            double D5, a5, y5, t5;

            Console.WriteLine("задача №5");
            Console.WriteLine("введите значение a");
            a5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение t");
            t5 = Convert.ToDouble(Console.ReadLine());


            D5 = (7.8 * Math.Pow(a5, 2) + 3.52 * t5) / (Math.Log(a5 + 2 * y5) + Math.Exp(y5));
            Console.WriteLine($"решение задачи №5={D5}");

            double L6, i6, y6;

            Console.WriteLine("задача №6");
            Console.WriteLine("введите значение i");
            i6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y6 = Convert.ToDouble(Console.ReadLine());

            L6 = (0.81 * Math.Cos(i6)) / (Math.Log(y6) + 2 * Math.Pow(i6, 3));
            Console.WriteLine($"решение задачи №6={L6}");

            double N7, m7, y7;

            Console.WriteLine("задача №7");
            Console.WriteLine("введите значение m");
            m7 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y7 = Convert.ToDouble(Console.ReadLine());

            N7 = (Math.Pow(m7, 2) + 2.8 * m7 + 0.355) / (Math.Cos(2 * y7) + 3.6);
            Console.WriteLine($"решение задачи №7={N7}");

            double T8, t8, y8;

            Console.WriteLine("задача №8");
            Console.WriteLine("введите значение t");
            t8 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y8 = Convert.ToDouble(Console.ReadLine());

            T8 = (2.37 * Math.Sin(t8 + 1)) / (Math.Sqrt(4 * Math.Pow(y8, 2) - 0.1 * y8 + 5));
            Console.WriteLine($"решение задачи №8={T8}");

            double V9, y9, w9;

            Console.WriteLine("задача №9");
            Console.WriteLine("введите значение y");
            y9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значени w");
            w9 = Convert.ToDouble(Console.ReadLine());

            V9 = (Math.Pow(y9 + 2 * w9, 3)) / (Math.Log(y9 + 0.75));
            Console.WriteLine($"решение задачи №9={V9}");

            double Z10, t10, y10;

            Console.WriteLine("задача №10");
            Console.WriteLine("введите значение t");
            t10 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y10 = Convert.ToDouble(Console.ReadLine());

            Z10 = (2 * t10 + y10 * Math.Cos(t10)) / (Math.Sqrt(y10 + 0.75));
            Console.WriteLine($"решение задачи №10={Z10}");

            double D11, y11, n11;

            Console.WriteLine("задача №11");
            Console.WriteLine("введите значение y");
            y11 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение n");
            n11 = Convert.ToDouble(Console.ReadLine());

            D11 = Math.Pow(y11, 2) + (0.5 * n11 + 4.8) / Math.Sin(y11);
            Console.WriteLine($"решение задачи №11={D11}");

            double R12, t12, y12;

            Console.WriteLine("задача №12");
            Console.WriteLine("введите значение t");
            t12 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y12 = Convert.ToDouble(Console.ReadLine());

            R12 = (Math.Sin(Math.Pow(2 * t12 + 1, 2)) + 0.3) / (Math.Log(t12 + y12));
            Console.WriteLine($"решение задачи №12={R12}");

            double A13, y13, h13, k13;

            Console.WriteLine("задача №13");
            Console.WriteLine("введите значение y");
            y13 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение h");
            h13 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение k");
            k13 = Convert.ToDouble(Console.ReadLine());

            A13 = (Math.Sin(2 * y13 + h13) + Math.Pow(h13, 2)) / (Math.Exp(k13) + y13);
            Console.WriteLine($"решение задачи №13={A13}");

            double P14, y14, h14;

            Console.WriteLine("задача №14");
            Console.WriteLine("введите значение y");
            y14 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение h");
            h14 = Convert.ToDouble(Console.ReadLine());

            P14 = (Math.Exp(y14 + 2.5) + 7.1 * Math.Pow(h14, 3)) / (Math.Log(Math.Sqrt(y14 + 0.04 * h14)));
            Console.WriteLine($"решение задачи №14={P14}");

            double F15, y15, j15;

            Console.WriteLine("задача №15");
            Console.WriteLine("введите значение y");
            y15 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение j");
            j15 = Convert.ToDouble(Console.ReadLine());

            F15 = (2 * Math.Sin(0.354 * y15 + 1)) / (Math.Log(y15 + 2 * j15));
            Console.WriteLine($"решение задачи №15={F15}");

            double W16,t16, r16, y16;

            Console.WriteLine("задача №16");
            Console.WriteLine("введите значение r");
            r16 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y16 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение t");
            t16 = Convert.ToDouble(Console.ReadLine());

            W16 = (4 * Math.Pow(t16, 3) + Math.Log(r16)) / (Math.Exp(y16 + r16) + 7.2 + Math.Sin(r16)); 
            Console.WriteLine($"решение задачи №16={W16}");

            double H17, y17, n17;

            Console.WriteLine("задача №17");
            Console.WriteLine("введите значение y");
            y17 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение n");
            n17 = Convert.ToDouble(Console.ReadLine());
            

            H17 = (Math.Pow(y17,2)-0.8*y17+Math.Sqrt(y17))/(23.1*Math.Pow(n17,2)+Math.Cos(n17));
            Console.WriteLine($"решение задачи №17={H17}");

            double R18, y18, k18;

            Console.WriteLine("задача №18");
            Console.WriteLine("введите значение y");
            y18 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение k");
            k18 = Convert.ToDouble(Console.ReadLine());

            R18 = (Math.Sqrt(Math.Pow(Math.Sin(y18), 2) + 6.835)) / (Math.Log(y18 + k18) + 3 * Math.Pow(y18, 2));
            Console.WriteLine($"решение задачи №18={R18}");

            double E19, y19, q19;

            Console.WriteLine("задача №19 ");
            Console.WriteLine("Введите значение y");
            y19 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите занчение a");
            q19 = Convert.ToDouble(Console.ReadLine());

            E19 = (Math.Log(0.7 * y1 + 2 * q19)) / (Math.Sqrt(3 * Math.Pow(y19, 20) + 0.5 * y1 + 4));
            Console.WriteLine($"решение задачи №19={E19}");

            double K20, t20, l20, y20;

            Console.WriteLine("задача №20");
            Console.WriteLine("введите занчение t");
            t20 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите занчение l");
            l20 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите занчение y");
            y20 = Convert.ToDouble(Console.ReadLine());

            K20 = (2 * Math.Pow(t20, 2) + 3 * l20 + 7.2) / (Math.Log(y20) + Math.Exp(2 * l20));
            Console.WriteLine($"решение задачи №20={K20}");

            double Q21, k21, p21, x21, d21;

            Console.WriteLine("задача №21");
            Console.WriteLine("введите занчение k");
            k21 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите занчение p");
            p21 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите занчение x");
            x21 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите занчение d");
            d21 = Convert.ToDouble(Console.ReadLine());

            Q21 = (Math.Sqrt(k21 * 2.6 * p21 * Math.Sin(k21))) / (x21 - Math.Pow(d21, 3));
            Console.WriteLine($"решение задачи №21={Q21}");

            double S22, y22, t22;

            Console.WriteLine("задача №22");
            Console.WriteLine("введите занчение y");
            y22 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите занчение t");
            t22 = Convert.ToDouble(Console.ReadLine());

            S22 = (4.351 * Math.Pow(y22, 3) + 2 * t22 * Math.Log(t22)) / (Math.Sqrt(Math.Cos(2 * y22) + 4.351));
            Console.WriteLine($"решение задачи №22={S22}");

            double R23, y23, d23;

            Console.WriteLine("задача №23");
            Console.WriteLine("введите значение y");
            y23 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение d");
            d23 = Convert.ToDouble(Console.ReadLine());


            R23 = (Math.Pow(Math.Sin(y23), 3) + 0.3 * d23)/ (Math.Exp(y23) + Math.Log(d23));
            Console.WriteLine($"решение задачи №23={R23}");

            double U24, k24, y24;

            Console.WriteLine("заадча №24");
            Console.WriteLine("введите значение k");
            k24 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y24 = Convert.ToDouble(Console.ReadLine());


            U24 = (Math.Log(2 * k24 + 4.3)) / (Math.Exp(k24 + y24) + Math.Sqrt(y24));
            Console.WriteLine($"решение задачи №24={U24}");

            double L25, c25, t25;

            Console.WriteLine("задача №25");
            Console.WriteLine("введите значение c");
            c25 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение t");
            t25 = Convert.ToDouble(Console.ReadLine());


            L25 = Math.Pow(Math.Cos(c25), 2) + (3 * Math.Pow(t25, 2) + 4) / (Math.Sqrt(c25 + t25));
            Console.WriteLine($"решение задчи №25={L25}");

            double T26, u26, y26;

            Console.WriteLine("задача№26");
            Console.WriteLine("введите значение u");
            u26 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y26 = Convert.ToDouble(Console.ReadLine());
            

            T26 = (Math.Sin(2*u26))/(Math.Log(2*y26+u26));
            Console.WriteLine($"решение задачи №26={T26}");

            double Z27, p27, y27;

            Console.WriteLine("задача №27");
            Console.WriteLine("введите значение p");
            p27 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y27 = Convert.ToDouble(Console.ReadLine());


            Z27 = (Math.Sin(Math.Pow(p27 + 0.4, 2))) / (Math.Pow(y27, 2) + 7.325 * p27);
            Console.WriteLine($"решение задачи №27={Z27}");

            double W28, v28, y28;

            Console.WriteLine("задача №28");
            Console.WriteLine("введите значение v");
            v28 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y28 = Convert.ToDouble(Console.ReadLine());


            W28 = (0.004 * v28 + Math.Exp(2 * y28)) / (Math.Exp(y28 / 2));
            Console.WriteLine($"решение задачи №28={W28}");

            double T29, h29, y29;

            Console.WriteLine("задача №29");
            Console.WriteLine("введите значение h");
            h29 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y29 = Convert.ToDouble(Console.ReadLine());


            T29 = (0.355 * Math.Pow(h29, 2) - 4.355) / (Math.Exp(y29 + h29) + Math.Sqrt(2.7 * y29));
            Console.WriteLine($"решение задачи №29={T29}");

            double N30, y30, p30;

            Console.WriteLine("задача №30");
            Console.WriteLine("введите значение y");
            y30 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение p");
            p30 = Convert.ToDouble(Console.ReadLine());

            N30 = (3 * Math.Pow(y30, 2) + Math.Sqrt(y30 + 1))/ (Math.Log(p30 + y30) + Math.Exp(p30));
            Console.WriteLine($"решение задачи №30={N30}");
            Console.WriteLine("нажмите любую клавишу чтобы закрыть");
            Console.ReadKey();
        }

    }
}
    

