using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndvDesktop
{
    class Parameters
    {
        public static Dictionary<int, double> values = new Dictionary<int, double>
        {
            {0, 0.2 },
            {1, 0.4 },
            {2, 0.6 },
            {3, 0.8 },
            {4, 1.0 }
        };

        public static string[] arrayA1 = new string[]
        {
            "є потреба в перспективній концепції",
            "є пріоритетна потреба в перспективній концепції",
            "є потреба сильної ідеї та готового продукту",
            "значна потреба перспективної, сильної ідеї та готового продукту",
            "пріоритетна потреба перспективної, сильної ідеї та готового продукту"
        };

        public static string[] arrayA2 = new string[]
        {
            "високий",
            "середній",
            "низький",
            "дуже низький",
            "мінімальний"
        };

        public static string[] arrayA3 = new string[]
        {
            "дуже низькі",
            "низькі",
            "середні",
            "вище середнього",
            "високі"
        };

        public static int[] results = new int[3];
        public static int[] coefficients = new int[3];
        public static double[] z = new double[5];

        public static double GetWi(int i)
        {
            double wi = Convert.ToDouble(coefficients[i]) / Convert.ToDouble(coefficients[0] + coefficients[1] + coefficients[2]);
            return wi;
        }
    }
}
