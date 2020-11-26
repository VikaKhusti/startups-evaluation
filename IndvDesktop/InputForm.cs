using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndvDesktop
{
    public partial class InputForm : Form
    {
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
        public InputForm()
        {
            InitializeComponent();
            cmxA1.DataSource = arrayA1;
            cmxA2.DataSource = arrayA2;
            cmxA3.DataSource = arrayA3;
        }
    }
}
