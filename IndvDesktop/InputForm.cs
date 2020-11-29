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
        public static bool OK = false;
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
        public InputForm()
        {
            InitializeComponent();
            cmxA1.DataSource = arrayA1;
            cmxA2.DataSource = arrayA2;
            cmxA3.DataSource = arrayA3;
        }

        private void cmxA1_SelectedIndexChanged(object sender, EventArgs e)
        {
            results[0] = cmxA1.SelectedIndex;
        }

        private void cmxA2_SelectedIndexChanged(object sender, EventArgs e)
        {
            results[1] = cmxA2.SelectedIndex;
        }

        private void cmxA3_SelectedIndexChanged(object sender, EventArgs e)
        {
            results[2] = cmxA3.SelectedIndex;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ToDo
            //try-catch for empty fields
            
            Form1 form = new Form1();
            form.ShowDialog();
            
        }
    }
}
